namespace Server.Items
{
    [FlipableAttribute( 0x1db9, 0x1dba )]
	public class LeatherCap : BaseArmor
	{
		public override int InitMinHits{ get{ return 30; } }
		public override int InitMaxHits{ get{ return 40; } }

		public override int DefaultStrReq{ get{ return 15; } }

		public override int ArmorBase{ get{ return 13; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Leather; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }

		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }


		[Constructible]
public LeatherCap() : base( 0x1DB9 )
		{
			Weight = 2.0;
		}

		[Constructible]
public LeatherCap( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( IGenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize(IGenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			if ( Weight == 1.0 )
				Weight = 2.0;
		}
	}
}