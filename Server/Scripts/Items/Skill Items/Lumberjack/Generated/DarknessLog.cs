// Generated File. DO NOT MODIFY BY HAND.
namespace Server.Items
{

    public class DarknessLog : BaseLog
    {
        [Constructable]
        public DarknessLog() : this(1) { }

        [Constructable]
        public DarknessLog(int amount) : base(CraftResource.Darkness, amount)
        {
            this.Hue = 1175;
        }

        public DarknessLog(Serial serial) : base(serial) { }

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!TryCreateBoards(from, 140, new DarknessBoard()))
            {
                return false;
            }
            return true;
        }
    }
}
