using Server.Spells;

namespace Server.Items
{
    public class EarthSpiritScroll : EarthSpellScroll
    {
        [Constructible]
        public EarthSpiritScroll() : this(1)
        {
        }


        [Constructible]
        public EarthSpiritScroll(int amount) : base(SpellEntry.EarthSpirit, 0x1F32, amount)
        {
        }

        [Constructible]
        public EarthSpiritScroll(Serial serial) : base(serial)
        {
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();
        }
    }
}