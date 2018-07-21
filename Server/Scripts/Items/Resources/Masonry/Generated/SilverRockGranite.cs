// Generated File. DO NOT MODIFY BY HAND.
namespace Server.Items {

	public class SilverRockGranite : BaseGranite {
		[Constructable]
		public SilverRockGranite() : base( CraftResource.SilverRock ) {
			this.Name = "silver rock granite";
			this.Hue = 0x3e9;
		}

		public SilverRockGranite( Serial serial ) : base( serial ) {}

		public string ResourceName { get { return "silver rock"; } }

		public override void Serialize( GenericWriter writer ) {
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader ) {
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}

		public override void OnSingleClick( Mobile from ) {
			from.SendMessage("Silver Rock Granite");
		}
	}	
}
