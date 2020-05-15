//Generated file.  Do not modify by hand.
namespace Server.Items
{
    [FlipableAttribute(0x1079, 0x1078)]
    public class BalronHide : BaseHides, IScissorable
    {
        [Constructable]
        public BalronHide() : this(1)
        {
        }

        [Constructable]
        public BalronHide(int amount) : base(CraftResource.BalronLeather, amount)
        {
            this.Hue = 1175;
        }

        public BalronHide(Serial serial) : base(serial)
        {
        }

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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (Deleted || !from.CanSee(this)) return false;

            if (Core.AOS && !IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(502437); // Items you wish to cut must be in your backpack
                return false;
            }
            base.ScissorHelper(from, new BalronLeather(), 1);

            return true;
        }
    }
}
