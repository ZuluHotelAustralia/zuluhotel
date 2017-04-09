using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class ControlUndeadScroll : SpellScroll
	{
		[Constructable]
		public ControlUndeadScroll() : this( 1 )
		{
		}

		[Constructable]
		public ControlUndeadScroll( int amount ) : base( 100, 0x2260, amount )
		{
		}

		public ControlUndeadScroll( Serial serial ) : base( serial )
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