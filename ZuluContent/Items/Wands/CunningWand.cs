﻿using Server.Spells.Second;

namespace Server.Items
{
    public class CunningWand : BaseWand
    {

        [Constructible]
        public CunningWand() : base(WandEffect.Cunning, 5, 30)
        {
        }

        [Constructible]
        public CunningWand(Serial serial) : base(serial)
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
            Cast(new CunningSpell(from, this));
        }
    }
}
