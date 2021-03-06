using System;

namespace Server.Items
{
    public class Candelabra : BaseLight, IShipwreckedItem
	{
		public override int LitItemID{ get { return 0xB1D; } }
		public override int UnlitItemID{ get { return 0xA27; } }


		[Constructible]
public Candelabra() : base( 0xA27 )
		{
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle225;
			Weight = 3.0;
		}

		[Constructible]
public Candelabra( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( IGenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 1 );

			writer.Write( m_IsShipwreckedItem );
		}

		public override void Deserialize( IGenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			switch ( version )
			{
				case 1:
				{
					m_IsShipwreckedItem = reader.ReadBool();
					break;
				}
			}
		}

		public override void OnSingleClick( Mobile from )
		{
			base.OnSingleClick( from );

			if ( m_IsShipwreckedItem )
				LabelTo( from, 1041645 );	//recovered from a shipwreck
		}

		#region IShipwreckedItem Members

		private bool m_IsShipwreckedItem;

		[CommandProperty( AccessLevel.GameMaster )]
		public bool IsShipwreckedItem
		{
			get { return m_IsShipwreckedItem; }
			set { m_IsShipwreckedItem = value; }
		}
		#endregion
	}
}
