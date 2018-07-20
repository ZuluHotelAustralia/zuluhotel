// Generated File. DO NOT MODIFY BY HAND.
namespace Server.Items {

	public class ZuluBoard : Board {
		[Constructable]
		public ZuluBoard() : this( 1 ) {}

		[Constructable]
		public ZuluBoard( int amount ) : base( CraftResource.Zulu, amount ) {
			this.Name = "zulu board";
			this.Hue = 1160;
		}

		public ZuluBoard( Serial serial ) : base( serial ) {}

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
