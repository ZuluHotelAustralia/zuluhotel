//Generated file.  Do not modify by hand.

namespace Server.Items
{
    [FlipableAttribute(0x1079, 0x1078)]
    public class OstardHide : BaseHide
    {
        [Constructible]
        public OstardHide() : this(1)
        {
        }


        [Constructible]
        public OstardHide(int amount) : base(CraftResource.OstardLeather, amount)
        {
        }

        [Constructible]
        public OstardHide(Serial serial) : base(serial)
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