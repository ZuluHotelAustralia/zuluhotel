// Generated File. DO NOT MODIFY BY HAND.
namespace Server.Items {

	public class HardrangerLog : Log {
		[Constructable]
		public HardrangerLog() : this( 1 ) {}

		[Constructable]
		public HardrangerLog( int amount ) : base( CraftResource.Hardranger, amount ) {}

		public HardrangerLog( Serial serial ) : base( serial ) {}

		public override void Serialize( GenericWriter writer ) {
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader ) {
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}

		public override bool Axe( Mobile from, BaseAxe axe ) {
			if ( !TryCreateBoards( from,   65 , new HardrangerBoard() ) ) {
				return false;
			}
			return true;
		}
	}	
}