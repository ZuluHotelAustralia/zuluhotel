namespace Server.Items
{
    [Flipable(0x153b, 0x153c)]
    public class HalfApron : BaseWaist
    {
        public override int InitMinHits => 70;

        public override int InitMaxHits => 70;


        [Constructible]
        public HalfApron() : this(0)
        {
        }


        [Constructible]
        public HalfApron(int hue) : base(0x153b, hue)
        {
            Weight = 2.0;
        }

        [Constructible]
        public HalfApron(Serial serial) : base(serial)
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
        }
    }
}