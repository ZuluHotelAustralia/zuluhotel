// Generated File. DO NOT MODIFY BY HAND.
namespace Server.Items {

	public class SwampwoodBoard : Board {
		[Constructable]
		public SwampwoodBoard() : this( 1 ) {}

		[Constructable]
		public SwampwoodBoard( int amount ) : base( CraftResource.Swampwood, amount ) {
			this.Hue = 1177;
		}

		public string ResourceName { get { return "swampwood"; } }
		public double ResourceQuality { get { return 1.50; } }

		public SwampwoodBoard( Serial serial ) : base( serial ) {}

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
