// Generated File. DO NOT MODIFY BY HAND.
namespace Server.Items {

	public class BlackDwarfGranite : BaseGranite {
		[Constructable]
		public BlackDwarfGranite() : base( CraftResource.BlackDwarf ) {
			this.Hue = 0x451;
		}

		public BlackDwarfGranite( Serial serial ) : base( serial ) {}

		public string ResourceName { get { return "black dwarf"; } }

		public override void Serialize( GenericWriter writer ) {
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader ) {
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}

		public override void OnSingleClick( Mobile from ) {
			from.SendMessage("Black Dwarf Granite");
		}
	}	
}
