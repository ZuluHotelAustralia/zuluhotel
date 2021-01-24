using Server.Network;
using Server.Targeting;
using ZuluContent.Zulu.Engines.Magic;

namespace Server.Spells.Fourth
{
    public class GreaterHealSpell : MagerySpell
    {
        public GreaterHealSpell(Mobile caster, Item scroll) : base(caster, scroll)
        {
        }


        public override void OnCast()
        {
            Caster.Target = new InternalTarget(this);
        }

        public void Target(Mobile m)
        {
            if (!Caster.CanSee(m))
            {
                Caster.SendLocalizedMessage(500237); // Target can not be seen.
            }
            else if (m.Poisoned)
            {
                Caster.LocalOverheadMessage(MessageType.Regular, 0x22, Caster == m ? 1005000 : 1010398);
            }
            else if (CheckBSequence(m))
            {
                SpellHelper.Turn(Caster, m);

                // Algorithm: (40% of magery) + (1-10)

                var toHeal = (Caster.Skills[SkillName.Magery].Value * 0.4);
                toHeal += Utility.Random(1, 10);

                Caster.FireHook(h => h.OnHeal(Caster, m, ref toHeal));

                //m.Heal( toHeal, Caster );
                SpellHelper.Heal((int) toHeal, m, Caster);

                m.FixedParticles(0x376A, 9, 32, 5030, EffectLayer.Waist);
                m.PlaySound(0x202);
            }

            FinishSequence();
        }

        public class InternalTarget : Target
        {
            private readonly GreaterHealSpell m_Owner;

            public InternalTarget(GreaterHealSpell owner) : base(12, false, TargetFlags.Beneficial)
            {
                m_Owner = owner;
            }

            protected override void OnTarget(Mobile from, object o)
            {
                if (o is Mobile) m_Owner.Target((Mobile) o);
            }

            protected override void OnTargetFinish(Mobile from)
            {
                m_Owner.FinishSequence();
            }
        }
    }
}