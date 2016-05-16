using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class WyvernStrikeScroll : SpellScroll
	{
		[Constructable]
		public WyvernStrikeScroll() : this( 1 )
		{
		}

		[Constructable]
		public WyvernStrikeScroll( int amount ) : base( 111, 0x2260, amount )
		{
		}

		public WyvernStrikeScroll( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}


	}
}