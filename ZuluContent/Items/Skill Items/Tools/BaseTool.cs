using System;
using Server.Network;
using Server.Engines.Craft;

namespace Server.Items
{
    public enum ToolQuality
	{
		Low,
		Regular,
		Exceptional
	}

	public abstract class BaseTool : Item, IUsesRemaining, ICraftable
	{
        private Mobile m_Crafter;
        private ToolQuality m_Quality;
        private int m_UsesRemaining;

        public BaseTool( int itemID ) : this( Utility.RandomMinMax( 25, 75 ), itemID )
		{
		}

        public BaseTool( int uses, int itemID ) : base( itemID )
		{
			m_UsesRemaining = uses;
			m_Quality = ToolQuality.Regular;
		}

        public BaseTool( Serial serial ) : base( serial )
		{
		}

        [CommandProperty( AccessLevel.GameMaster )]
		public Mobile Crafter
		{
			get{ return m_Crafter; }
			set{ m_Crafter = value; }
		}

        [CommandProperty( AccessLevel.GameMaster )]
		public ToolQuality Quality
		{
			get{ return m_Quality; }
			set{ UnscaleUses(); m_Quality = value; ScaleUses(); }
		}

        public virtual bool BreakOnDepletion { get { return true; } }

        public abstract CraftSystem CraftSystem{ get; }

        [CommandProperty( AccessLevel.GameMaster )]
		public int UsesRemaining
		{
			get { return m_UsesRemaining; }
			set { m_UsesRemaining = value; }
		}

        public bool ShowUsesRemaining{ get{ return true; } set{} }

        public void ScaleUses()
		{
			m_UsesRemaining = m_UsesRemaining * GetUsesScalar() / 100;
		}

        public void UnscaleUses()
		{
			m_UsesRemaining = m_UsesRemaining * 100 / GetUsesScalar();
		}

        public int GetUsesScalar()
		{
			if ( m_Quality == ToolQuality.Exceptional )
				return 200;

			return 100;
		}

        public virtual void DisplayDurabilityTo( Mobile m )
		{
			LabelToAffix( m, 1017323, AffixType.Append, ": " + m_UsesRemaining.ToString() ); // Durability
		}

        public static bool CheckAccessible( Item tool, Mobile m )
		{
			return tool.IsChildOf( m ) || tool.Parent == m;
		}

        public override void OnSingleClick( Mobile from )
		{
			DisplayDurabilityTo( from );

			base.OnSingleClick( from );
		}

        public override void OnDoubleClick( Mobile from )
		{
			if ( IsChildOf( from.Backpack ) || Parent == from )
			{
				CraftSystem system = CraftSystem;

				int num = system.CanCraft( from, this, null );

				if ( num > 0 )
				{
					from.SendLocalizedMessage( num );
				}
				else
				{
					from.SendGump( new CraftGump( from, system, this, null ) );
				}
			}
			else
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
		}

        public override void Serialize( IGenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version

			writer.Write( (Mobile) m_Crafter );
			writer.Write( (int) m_Quality );

			writer.Write( (int) m_UsesRemaining );
		}

        public override void Deserialize( IGenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			switch ( version )
			{
				case 1:
				{
					m_Crafter = reader.ReadMobile();
					m_Quality = (ToolQuality) reader.ReadInt();
					goto case 0;
				}
				case 0:
				{
					m_UsesRemaining = reader.ReadInt();
					break;
				}
			}
		}

        #region ICraftable Members

        public bool PlayerConstructed { get; set; }

        public int OnCraft( int quality, bool makersMark, Mobile from, CraftSystem craftSystem, Type typeRes, BaseTool tool, CraftItem craftItem, int resHue )
		{
			Quality = (ToolQuality)quality;

			if ( makersMark )
				Crafter = from;

			return quality;
		}

        #endregion
    }
}
