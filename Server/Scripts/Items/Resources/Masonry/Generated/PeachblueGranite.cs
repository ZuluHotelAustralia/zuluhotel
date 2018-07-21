// Generated File. DO NOT MODIFY BY HAND.
namespace Server.Items {

	public class PeachblueGranite : BaseGranite {
		[Constructable]
		public PeachblueGranite() : base( CraftResource.Peachblue ) {
			this.Name = "peachblue granite";
			this.Hue = 0x49c;
		}

		public PeachblueGranite( Serial serial ) : base( serial ) {}

		public string ResourceName { get { return "peachblue"; } }

		public override void Serialize( GenericWriter writer ) {
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader ) {
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}

		public override void OnSingleClick( Mobile from ) {
			from.SendMessage("Peachblue Granite");
		}
	}	
}
