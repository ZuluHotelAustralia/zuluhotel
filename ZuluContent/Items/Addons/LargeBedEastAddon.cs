namespace Server.Items
{
    public class LargeBedEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new LargeBedEastDeed(); } }


		[Constructible]
public LargeBedEastAddon()
		{
			AddComponent( new AddonComponent( 0xA7D ), 0, 0, 0 );
			AddComponent( new AddonComponent( 0xA7C ), 0, 1, 0 );
			AddComponent( new AddonComponent( 0xA79 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 0xA78 ), 1, 1, 0 );
		}

		[Constructible]
public LargeBedEastAddon( Serial serial ) : base( serial )
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

	public class LargeBedEastDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new LargeBedEastAddon(); } }
		public override int LabelNumber{ get{ return 1044324; } } // large bed (east)


		public LargeBedEastDeed()
		{
		}

		public LargeBedEastDeed( Serial serial ) : base( serial )
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