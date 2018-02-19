// Generated File. DO NOT MODIFY BY HAND.
namespace Server.Items {

	public class BloodhorseBoard : Board {
		[Constructable]
		public BloodhorseBoard() : this( 1 ) {}

		[Constructable]
		public BloodhorseBoard( int amount ) : base( CraftResource.Bloodhorse, amount ) {}

		public BloodhorseBoard( Serial serial ) : base( serial ) {}

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