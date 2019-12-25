// Generated File. DO NOT MODIFY BY HAND.
namespace Server.Items {

	[FlipableAttribute( 0x1BF2, 0x1BEF )]
	public class EbonTwilightSapphireIngot : BaseIngot {
		[Constructable]
		public EbonTwilightSapphireIngot() : this( 1 ) {}

		[Constructable]
		public EbonTwilightSapphireIngot( int amount ) : base( CraftResource.EbonTwilightSapphire, amount ) {
			this.Hue = 2760;
		}

		public EbonTwilightSapphireIngot( Serial serial ) : base( serial ) {}

		public override void Serialize( GenericWriter writer ) {
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader ) {
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}	
}
