// Generated File. DO NOT MODIFY BY HAND.

namespace Server.Items
{
    public class MysticOre : BaseOre
    {
        [Constructible]
        public MysticOre() : this(1)
        {
        }


        [Constructible]
        public MysticOre(int amount) : base(CraftResource.Mystic, amount)
        {
        }

        [Constructible]
        public MysticOre(Serial serial) : base(serial)
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

        public override BaseIngot GetIngot()
        {
            return new MysticIngot();
        }
    }
}