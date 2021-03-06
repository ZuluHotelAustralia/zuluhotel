﻿using Server.Spells.Eighth;

namespace Server.Items
{
    public class WaterElementalWand : BaseWand
    {
        [Constructible]
        public WaterElementalWand() : base(WandEffect.WaterElemental, 2, 10)
        {
        }

        [Constructible]
        public WaterElementalWand(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        public override void OnWandUse(Mobile from)
        {
            Cast(new WaterElementalSpell(from, this));
        }
    }
}
