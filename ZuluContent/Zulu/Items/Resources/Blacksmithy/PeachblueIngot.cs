// Generated File. DO NOT MODIFY BY HAND.

namespace Server.Items
{
    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class PeachblueIngot : BaseIngot
    {
        [Constructible]
        public PeachblueIngot() : this(1)
        {
        }


        [Constructible]
        public PeachblueIngot(int amount) : base(CraftResource.Peachblue, amount)
        {
        }

        [Constructible]
        public PeachblueIngot(Serial serial) : base(serial)
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