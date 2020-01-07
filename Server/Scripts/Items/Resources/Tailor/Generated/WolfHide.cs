//Generated file.  Do not modify by hand.
namespace Server.Items{
	[FlipableAttribute( 0x1079, 0x1078 )]
	public class WolfHide : BaseHides, IScissorable
	{
		[Constructable]
		public WolfHide() : this( 1 )
		{
		}

		[Constructable]
		public WolfHide( int amount ) : base( CraftResource.WolfLeather, amount )
		{
			this.Hue = 1102;
		}

		public WolfHide( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public bool Scissor( Mobile from, Scissors scissors )
		{
			if ( Deleted || !from.CanSee( this ) ) return false;

			if ( Core.AOS && !IsChildOf ( from.Backpack ) )
			{
				from.SendLocalizedMessage ( 502437 ); // Items you wish to cut must be in your backpack
				return false;
			}
			base.ScissorHelper( from, new WolfLeather(), 1 );

			return true;
		}
	}
}
