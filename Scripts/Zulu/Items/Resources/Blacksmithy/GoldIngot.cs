// Generated File. DO NOT MODIFY BY HAND.
namespace Server.Items
{

    [FlipableAttribute(0x1BF2, 0x1BEF)]
    public class GoldIngot : BaseIngot
    {
        [Constructable]
        public GoldIngot() : this(1) { }

        [Constructable]
        public GoldIngot(int amount) : base(CraftResource.Gold, amount)
        {
            this.Hue = 2793;
        }

        public GoldIngot(Serial serial) : base(serial) { }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
