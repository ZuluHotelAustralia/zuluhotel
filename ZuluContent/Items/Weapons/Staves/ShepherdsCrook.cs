using System;
using Server.Network;
using Server.Targeting;
using Server.Mobiles;

namespace Server.Items
{
    [FlipableAttribute(0xE81, 0xE82)]
    public class ShepherdsCrook : BaseStaff
    {
        public override int DefaultMinDamage => 3;
        public override int DefaultMaxDamage => 12;
        public override int DefaultSpeed => 30;
        public override int InitMinHits => 70;
        public override int InitMaxHits => 70;


        [Constructible]
        public ShepherdsCrook() : base(0xE81)
        {
            Weight = 4.0;
            Layer = Layer.TwoHanded;
        }

        [Constructible]
        public ShepherdsCrook(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int) 0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (Weight == 2.0)
                Weight = 4.0;
        }

        public override void OnDoubleClick(Mobile from)
        {
            from.SendLocalizedMessage(502464); // Target the animal you wish to herd.
            from.Target = new HerdingTarget();
        }

        private class HerdingTarget : Target
        {
            public HerdingTarget() : base(10, false, TargetFlags.None)
            {
            }

            protected override void OnTarget(Mobile from, object targ)
            {
                if (targ is BaseCreature)
                {
                    BaseCreature bc = (BaseCreature) targ;

                    if (IsHerdable(bc))
                    {
                        if (bc.Controlled)
                        {
                            bc.PrivateOverheadMessage(MessageType.Regular, 0x3B2, 502467,
                                from.NetState); // That animal looks tame already.
                        }
                        else
                        {
                            from.SendLocalizedMessage(502475); // Click where you wish the animal to go.
                            from.Target = new InternalTarget(bc);
                        }
                    }
                    else
                    {
                        from.SendLocalizedMessage(502468); // That is not a herdable animal.
                    }
                }
                else
                {
                    from.SendLocalizedMessage(502472); // You don't seem to be able to persuade that to move.
                }
            }

            private static Type[] m_ChampTamables = new[]
            {
                typeof(Imp), typeof(GiantScorpion), typeof(GiantRockSpider),
                typeof(Snake), typeof(LavaLizard), typeof(Drake), typeof(Dragon),
                typeof(GiantRat), typeof(Slime),
                typeof(DireWolf), typeof(HellHound)
            };

            private bool IsHerdable(BaseCreature bc)
            {
                if (bc.Tamable)
                    return true;

                return false;
            }

            private class InternalTarget : Target
            {
                private BaseCreature m_Creature;

                public InternalTarget(BaseCreature c) : base(10, true, TargetFlags.None)
                {
                    m_Creature = c;
                }

                protected override void OnTarget(Mobile from, object targ)
                {
                    if (targ is IPoint2D)
                    {
                        double min = m_Creature.MinTameSkill - 30;
                        double max = m_Creature.MinTameSkill + 30 + Utility.Random(10);

                        if (max <= from.Skills[SkillName.Herding].Value)
                            m_Creature.PrivateOverheadMessage(MessageType.Regular, 0x3B2, 502471,
                                from.NetState); // That wasn't even challenging.

                        if (from.CheckTargetSkill(SkillName.Herding, m_Creature, min, max))
                        {
                            IPoint2D p = (IPoint2D) targ;

                            if (targ != from)
                                p = new Point2D(p.X, p.Y);

                            m_Creature.TargetLocation = p;
                            from.SendLocalizedMessage(502479); // The animal walks where it was instructed to.
                        }
                        else
                        {
                            from.SendLocalizedMessage(502472); // You don't seem to be able to persuade that to move.
                        }
                    }
                }
            }
        }
    }
}