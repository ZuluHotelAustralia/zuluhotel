using System;
using System.Linq;
using Server.Gumps;
using Server.Items;
using Server.Mobiles;
using Server.Multis;

namespace Server.Regions
{
  public class HouseRegion : BaseRegion
  {
    public static readonly int HousePriority = DefaultPriority + 1;

    public static TimeSpan CombatHeatDelay = TimeSpan.FromSeconds(30.0);

    private bool m_Recursion;

    public HouseRegion(BaseHouse house) : base(null, house.Map, HousePriority, GetArea(house))
    {
      House = house;

      Point3D ban = house.RelativeBanLocation;

      GoLocation = new Point3D(house.X + ban.X, house.Y + ban.Y, house.Z + ban.Z);
    }

    public BaseHouse House { get; }

    public static void Initialize()
    {
      EventSink.Login += OnLogin;
    }

    public static void OnLogin(Mobile m)
    {
      BaseHouse house = BaseHouse.FindHouseAt(m);

      if (house?.Public == false && !house.IsFriend(m))
        m.Location = house.BanLocation;
    }

    public override bool AllowHousing(Mobile from, Point3D p) => false;

    private static Rectangle3D[] GetArea(BaseHouse house)
    {
      int x = house.X;
      int y = house.Y;
      // int z = house.Z;

      Rectangle2D[] houseArea = house.Area;
      Rectangle3D[] area = new Rectangle3D[houseArea.Length];

      for (int i = 0; i < area.Length; i++)
      {
        Rectangle2D rect = houseArea[i];
        area[i] = ConvertTo3D(new Rectangle2D(x + rect.Start.X, y + rect.Start.Y, rect.Width, rect.Height));
      }

      return area;
    }

    public override bool SendInaccessibleMessage(Item item, Mobile from)
    {
      if (item is Container)
        item.SendLocalizedMessageTo(from, 501647); // That is secure.
      else
        item.SendLocalizedMessageTo(from, 1061637); // You are not allowed to access this.

      return true;
    }

    public override bool CheckAccessibility(Item item, Mobile from) => House.CheckAccessibility(item, from);

    // Use OnLocationChanged instead of OnEnter because it can be that we enter a house region even though we're not actually inside the house
    public override void OnLocationChanged( Mobile m, Point3D oldLocation )
    {
      if ( m_Recursion )
        return;

      base.OnLocationChanged( m, oldLocation );

      m_Recursion = true;

      if ( m is BaseCreature && ((BaseCreature)m).NoHouseRestrictions )
      {
      }
      else if ( m is BaseCreature && ((BaseCreature)m).IsHouseSummonable && !(BaseCreature.Summoning || House.IsInside( oldLocation, 16 )) )
      {
      }
      else if ( House.IsBanned( m ) && House.IsInside( m ) )
      {
        m.Location = House.BanLocation;
        m.SendLocalizedMessage( 501284 ); // You may not enter.
      }

      m_Recursion = false;
    }

    public override bool OnMoveInto( Mobile from, Direction d, Point3D newLocation, Point3D oldLocation )
    {
      if ( !base.OnMoveInto( from, d, newLocation, oldLocation ) )
        return false;

      if ( from is BaseCreature && ((BaseCreature)from).NoHouseRestrictions )
      {
      }
      else if ( from is BaseCreature && !((BaseCreature)from).Controlled ) // Untamed creatures cannot enter public houses
      {
        return false;
      }
      else if ( from is BaseCreature && ((BaseCreature)from).IsHouseSummonable && !(BaseCreature.Summoning || House.IsInside( oldLocation, 16 )) )
      {
        return false;
      }
      else if ( House.IsBanned( from ) && House.IsInside( newLocation, 16 ) )
      {
        from.Location = House.BanLocation;
        from.SendLocalizedMessage( 501284 ); // You may not enter.

        return false;
      }

      return true;
    }
    public override bool OnDecay(Item item) =>
      (!House.HasLockedDownItem(item) && !House.HasSecureItem(item) || !House.IsInside(item)) && base.OnDecay(item);

    public override TimeSpan GetLogoutDelay(Mobile m) =>
      House.IsFriend(m) && House.IsInside(m)
        ? m.Aggressed.Any(info => info.Defender.Player && DateTime.UtcNow - info.LastCombatTime < CombatHeatDelay)
          ? base.GetLogoutDelay(m) : TimeSpan.Zero
        : base.GetLogoutDelay(m);

		public override void OnSpeech( SpeechEventArgs e )
		{
			base.OnSpeech( e );

			Mobile from = e.Mobile;
			Item sign = House.Sign;

			bool isOwner = House.IsOwner( from );
			bool isCoOwner = isOwner || House.IsCoOwner( from );
			bool isFriend = isCoOwner || House.IsFriend( from );

			if ( !isFriend )
				return;

			if ( !from.Alive )
				return;

			if ( !House.IsInside( from ) || !House.IsActive )
				return;
			else if ( e.HasKeyword( 0x33 ) ) // remove thyself
			{
				from.SendLocalizedMessage( 501326 ); // Target the individual to eject from this house.
				from.Target = new HouseKickTarget( House );
			}
			else if ( e.HasKeyword( 0x34 ) ) // I ban thee
			{
				from.SendLocalizedMessage( 501325 ); // Target the individual to ban from this house.
				from.Target = new HouseBanTarget( true, House );
			}
			else if ( e.HasKeyword( 0x23 ) ) // I wish to lock this down
			{
				if ( isCoOwner )
				{
					from.SendLocalizedMessage( 502097 ); // Lock what down?
					from.Target = new LockdownTarget( false, House );
				}
				else if ( isFriend )
				{
					from.SendLocalizedMessage( 1010587 ); // You are not a co-owner of this house.
				}
				else
				{
					from.SendLocalizedMessage( 502094 ); // You must be in your house to do this.
				}
			}
			else if ( e.HasKeyword( 0x24 ) ) // I wish to release this
			{
				if ( isCoOwner )
				{
					from.SendLocalizedMessage( 502100 ); // Choose the item you wish to release
					from.Target = new LockdownTarget( true, House );
				}
				else if ( isFriend )
				{
					from.SendLocalizedMessage( 1010587 ); // You are not a co-owner of this house.
				}
				else
				{
					from.SendLocalizedMessage( 502094 ); // You must be in your house to do this.
				}
			}
			else if ( e.HasKeyword( 0x25 ) ) // I wish to secure this
			{
				if ( isOwner )
				{
					from.SendLocalizedMessage( 502103 ); // Choose the item you wish to secure
					from.Target = new  SecureTarget( false, House );
				}
				else
				{
					from.SendLocalizedMessage( 502094 ); // You must be in your house to do this.
				}
			}
			else if ( e.HasKeyword( 0x26 ) ) // I wish to unsecure this
			{
				if ( isOwner )
				{
					from.SendLocalizedMessage( 502106 ); // Choose the item you wish to unsecure
					from.Target = new  SecureTarget( true, House );
				}
				else
				{
					from.SendLocalizedMessage( 502094 ); // You must be in your house to do this.
				}
			}
			else if ( e.HasKeyword( 0x27 ) ) // I wish to place a strongbox
			{
				if ( isOwner )
				{
					from.SendLocalizedMessage( 502109 ); // Owners do not get a strongbox of their own.
				}
				else if ( isCoOwner )
				{
					House.AddStrongBox( from );
				}
				else if ( isFriend )
				{
					from.SendLocalizedMessage( 1010587 ); // You are not a co-owner of this house.
				}
				else
				{
					from.SendLocalizedMessage( 502094 ); // You must be in your house to do this.
				}
			}
			else if ( e.HasKeyword( 0x28 ) ) // trash barrel
			{
				if ( isCoOwner )
				{
					House.AddTrashBarrel( from );
				}
				else if ( isFriend )
				{
					from.SendLocalizedMessage( 1010587 ); // You are not a co-owner of this house.
				}
				else
				{
					from.SendLocalizedMessage( 502094 ); // You must be in your house to do this.
				}
			}
		}

    public override bool OnDoubleClick(Mobile from, object o)
    {
      if (o is Container c)
      {
        SecureAccessResult res = House.CheckSecureAccess(from, c);

        switch (res)
        {
          case SecureAccessResult.Accessible:
            return true;
          case SecureAccessResult.Inaccessible:
            c.SendLocalizedMessageTo(@from, 1010563);
            return false;
          case SecureAccessResult.Insecure:
            break;
        }
      }

      return base.OnDoubleClick(from, o);
    }

    public override bool OnSingleClick(Mobile from, object o)
    {
      if (o is Item item)
      {
        if (House.HasLockedDownItem(item))
          item.LabelTo(from, 501643); // [locked down]
        else if (House.HasSecureItem(item))
          item.LabelTo(from, 501644); // [locked down & secure]
      }

      return base.OnSingleClick(from, o);
    }
  }
}
