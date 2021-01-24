using System;
using Server;
using Server.Items;
using Server.Scripts.Engines.Loot;

namespace Server.Mobiles
{
    [CorpseName("a deep sea serpents corpse")]
    public class DeepSeaSerpent : BaseCreature
    {
        [Constructible]
        public DeepSeaSerpent() : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a deep sea serpent";
            Body = 150;
            BaseSoundID = 447;

            Hue = Utility.Random(0x8A0, 5);

            SetStr(251, 425);
            SetDex(87, 135);
            SetInt(87, 155);

            SetHits(151, 255);

            SetDamage(6, 14);

            SetSkill(SkillName.MagicResist, 60.1, 75.0);
            SetSkill(SkillName.Tactics, 60.1, 70.0);
            SetSkill(SkillName.Wrestling, 60.1, 70.0);

            Fame = 6000;
            Karma = -6000;

            VirtualArmor = 60;
            CanSwim = true;
            CantWalk = true;

            if (Utility.RandomBool())
                PackItem(new SulfurousAsh(4));
            else
                PackItem(new BlackPearl(4));

            //PackItem( new SpecialFishingNet() );
        }

        public override void GenerateLoot()
        {
            AddLoot(LootTable.Table1);
        }

        public override bool HasBreath
        {
            get { return true; }
        }

        public override int Meat
        {
            get { return 1; }
        }

        public override int Hides
        {
            get { return 20; }
        }

        public override HideType HideType
        {
            get { return HideType.Serpent; }
        }

        [Constructible]
        public DeepSeaSerpent(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int) 0);
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);
            var version = reader.ReadInt();
        }
    }
}