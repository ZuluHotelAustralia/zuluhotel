using Server.Engines.Craft;

namespace Server.Items
{
    public class FlourSifter : BaseTool
	{
		public override CraftSystem CraftSystem{ get{ return DefCooking.CraftSystem; } }


		[Constructible]
public FlourSifter() : base( 0x103E )
		{
			Weight = 1.0;
		}


		[Constructible]
public FlourSifter( int uses ) : base( uses, 0x103E )
		{
			Weight = 1.0;
		}

		[Constructible]
public FlourSifter( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( IGenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( IGenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
