// Generated File. DO NOT MODIFY BY HAND.
namespace Server.Items {

	public class PinetreeBoard : Board {
		[Constructable]
		public PinetreeBoard() : this( 1 ) {}

		[Constructable]
		public PinetreeBoard( int amount ) : base( CraftResource.Pinetree, amount ) {}

		public PinetreeBoard( Serial serial ) : base( serial ) {}

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
