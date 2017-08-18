using System;
using System.Collections.Generic;

namespace Server.Items
{
    public enum CraftResource
    {
	None = 0,

	Iron,
	Gold,
	Spike,
	Fruity,
	Bronze,
	IceRock,
	BlackDwarf,
	DullCopper,
	Platinum,
	SilverRock,
	DarkPagan,
	Copper,
	Mystic,
	Spectral,
	OldBritain,
	Onyx,
	RedElven,
	Undead,
	Pyrite,
	Virginity,
	Malachite,
	Lavarock,
	Azurite,
	Dripstone,
	Executor,
	Peachblue,
	Destruction,
	Anra,
	Crystal,
	Doom,
	Goddess,
	NewZulu,
	DarkSableRuby,
	EbonTwilightSapphire,
	RadiantNimbusDiamond,

	RegularLeather = 101,
	SpinedLeather,
	HornedLeather,
	BarbedLeather,

	RedScales = 201,
	YellowScales,
	BlackScales,
	GreenScales,
	WhiteScales,
	BlueScales,

	RegularWood = 301,
	Pinetree,
	Cherry,
	Oak,
	PurplePassion,
	GoldenReflection,
	Hardranger,
	Jadewood,
	Darkwood,
	Stonewood,
	Sunwood,
	Gauntlet,
	Swampwood,
	Stardust,
	Silverleaf,
	Stormteal,
	Emeraldwood,
	Bloodwood,
	Crystalwood,
	Bloodhorse,
	Doomwood,
	Zulu,
	Darkness,
	Elven
    }

    public enum CraftResourceType
    {
	None,
	Metal,
	Leather,
	Scales,
	Wood
    }

    public class CraftAttributeInfo
    {
	private int m_WeaponFireDamage;
	private int m_WeaponColdDamage;
	private int m_WeaponPoisonDamage;
	private int m_WeaponEnergyDamage;
	private int m_WeaponChaosDamage;
	private int m_WeaponDirectDamage;
	private int m_WeaponDurability;
	private int m_WeaponLuck;
	private int m_WeaponGoldIncrease;
	private int m_WeaponLowerRequirements;

	private int m_ArmorPhysicalResist;
	private int m_ArmorFireResist;
	private int m_ArmorColdResist;
	private int m_ArmorPoisonResist;
	private int m_ArmorEnergyResist;
	private int m_ArmorDurability;
	private int m_ArmorLuck;
	private int m_ArmorGoldIncrease;
	private int m_ArmorLowerRequirements;

	private int m_RunicMinAttributes;
	private int m_RunicMaxAttributes;
	private int m_RunicMinIntensity;
	private int m_RunicMaxIntensity;

	public int WeaponFireDamage{ get{ return m_WeaponFireDamage; } set{ m_WeaponFireDamage = value; } }
	public int WeaponColdDamage{ get{ return m_WeaponColdDamage; } set{ m_WeaponColdDamage = value; } }
	public int WeaponPoisonDamage{ get{ return m_WeaponPoisonDamage; } set{ m_WeaponPoisonDamage = value; } }
	public int WeaponEnergyDamage{ get{ return m_WeaponEnergyDamage; } set{ m_WeaponEnergyDamage = value; } }
	public int WeaponChaosDamage{ get{ return m_WeaponChaosDamage; } set{ m_WeaponChaosDamage = value; } }
	public int WeaponDirectDamage{ get{ return m_WeaponDirectDamage; } set{ m_WeaponDirectDamage = value; } }
	public int WeaponDurability{ get{ return m_WeaponDurability; } set{ m_WeaponDurability = value; } }
	public int WeaponLuck{ get{ return m_WeaponLuck; } set{ m_WeaponLuck = value; } }
	public int WeaponGoldIncrease{ get{ return m_WeaponGoldIncrease; } set{ m_WeaponGoldIncrease = value; } }
	public int WeaponLowerRequirements{ get{ return m_WeaponLowerRequirements; } set{ m_WeaponLowerRequirements = value; } }

	public int ArmorPhysicalResist{ get{ return m_ArmorPhysicalResist; } set{ m_ArmorPhysicalResist = value; } }
	public int ArmorFireResist{ get{ return m_ArmorFireResist; } set{ m_ArmorFireResist = value; } }
	public int ArmorColdResist{ get{ return m_ArmorColdResist; } set{ m_ArmorColdResist = value; } }
	public int ArmorPoisonResist{ get{ return m_ArmorPoisonResist; } set{ m_ArmorPoisonResist = value; } }
	public int ArmorEnergyResist{ get{ return m_ArmorEnergyResist; } set{ m_ArmorEnergyResist = value; } }
	public int ArmorDurability{ get{ return m_ArmorDurability; } set{ m_ArmorDurability = value; } }
	public int ArmorLuck{ get{ return m_ArmorLuck; } set{ m_ArmorLuck = value; } }
	public int ArmorGoldIncrease{ get{ return m_ArmorGoldIncrease; } set{ m_ArmorGoldIncrease = value; } }
	public int ArmorLowerRequirements{ get{ return m_ArmorLowerRequirements; } set{ m_ArmorLowerRequirements = value; } }

	public int RunicMinAttributes{ get{ return m_RunicMinAttributes; } set{ m_RunicMinAttributes = value; } }
	public int RunicMaxAttributes{ get{ return m_RunicMaxAttributes; } set{ m_RunicMaxAttributes = value; } }
	public int RunicMinIntensity{ get{ return m_RunicMinIntensity; } set{ m_RunicMinIntensity = value; } }
	public int RunicMaxIntensity{ get{ return m_RunicMaxIntensity; } set{ m_RunicMaxIntensity = value; } }

	public CraftAttributeInfo()
	{
	}

	public static readonly CraftAttributeInfo Blank;
	public static readonly CraftAttributeInfo Gold, Spike, Fruity, Bronze, IceRock, BlackDwarf, DullCopper, Platinum, SilverRock, DarkPagan, Copper, Mystic, Spectral, OldBritain, Onyx, RedElven, Undead, Pyrite, Virginity, Malachite, Lavarock, Azurite, Dripstone, Executor, Peachblue, Destruction, Anra, Crystal, Doom, Goddess, NewZulu, DarkSableRuby, EbonTwilightSapphire, RadiantNimbusDiamond;

	public static readonly CraftAttributeInfo Spined, Horned, Barbed;
	public static readonly CraftAttributeInfo RedScales, YellowScales, BlackScales, GreenScales, WhiteScales, BlueScales;
	public static readonly CraftAttributeInfo Pinetree, Cherry, Oak, PurplePassion, GoldenReflection, Hardranger, Jadewood, Darkwood, Stonewood, Sunwood, Gauntlet, Swampwood, Stardust, Silverleaf, Stormteal, Emeraldwood, Bloodwood, Crystalwood, Bloodhorse, Doomwood, Zulu, Darkness, Elven;

	static CraftAttributeInfo()
	{
	    Blank = new CraftAttributeInfo();

	    CraftAttributeInfo info;

	    info = Gold = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Spike = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Fruity = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Bronze = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = IceRock = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = BlackDwarf = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = DullCopper = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Platinum = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = SilverRock = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = DarkPagan = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Copper = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Mystic = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Spectral = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = OldBritain = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Onyx = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = RedElven = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Undead = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Pyrite = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Virginity = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Malachite = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Lavarock = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Azurite = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Dripstone = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Executor = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Peachblue = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Destruction = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Anra = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Crystal = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Doom = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = Goddess = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = NewZulu = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = DarkSableRuby = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = EbonTwilightSapphire = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }

	    info = RadiantNimbusDiamond = new CraftAttributeInfo();

	    info.ArmorPhysicalResist = 6;
	    info.ArmorDurability = 50;
	    info.ArmorLowerRequirements = 20;
	    info.WeaponDurability = 100;
	    info.WeaponLowerRequirements = 50;
	    info.RunicMinAttributes = 1;
	    info.RunicMaxAttributes = 2;
	    if ( Core.ML )
	    {
		info.RunicMinIntensity = 40;
		info.RunicMaxIntensity = 100;
	    }
	    else
	    {
		info.RunicMinIntensity = 10;
		info.RunicMaxIntensity = 35;
	    }
                        

	    CraftAttributeInfo spined = Spined = new CraftAttributeInfo();

	    spined.ArmorPhysicalResist = 5;
	    spined.ArmorLuck = 40;
	    spined.RunicMinAttributes = 1;
	    spined.RunicMaxAttributes = 3;
	    if ( Core.ML )
	    {
		spined.RunicMinIntensity = 40;
		spined.RunicMaxIntensity = 100;
	    }
	    else
	    {
		spined.RunicMinIntensity = 20;
		spined.RunicMaxIntensity = 40;
	    }

	    CraftAttributeInfo horned = Horned = new CraftAttributeInfo();

	    horned.ArmorPhysicalResist = 2;
	    horned.ArmorFireResist = 3;
	    horned.ArmorColdResist = 2;
	    horned.ArmorPoisonResist = 2;
	    horned.ArmorEnergyResist = 2;
	    horned.RunicMinAttributes = 3;
	    horned.RunicMaxAttributes = 4;
	    if ( Core.ML )
	    {
		horned.RunicMinIntensity = 45;
		horned.RunicMaxIntensity = 100;
	    }
	    else
	    {
		horned.RunicMinIntensity = 30;
		horned.RunicMaxIntensity = 70;
	    }

	    CraftAttributeInfo barbed = Barbed = new CraftAttributeInfo();

	    barbed.ArmorPhysicalResist = 2;
	    barbed.ArmorFireResist = 1;
	    barbed.ArmorColdResist = 2;
	    barbed.ArmorPoisonResist = 3;
	    barbed.ArmorEnergyResist = 4;
	    barbed.RunicMinAttributes = 4;
	    barbed.RunicMaxAttributes = 5;
	    if ( Core.ML )
	    {
		barbed.RunicMinIntensity = 50;
		barbed.RunicMaxIntensity = 100;
	    }
	    else
	    {
		barbed.RunicMinIntensity = 40;
		barbed.RunicMaxIntensity = 100;
	    }

	    CraftAttributeInfo red = RedScales = new CraftAttributeInfo();

	    red.ArmorFireResist = 10;
	    red.ArmorColdResist = -3;

	    CraftAttributeInfo yellow = YellowScales = new CraftAttributeInfo();

	    yellow.ArmorPhysicalResist = -3;
	    yellow.ArmorLuck = 20;

	    CraftAttributeInfo black = BlackScales = new CraftAttributeInfo();

	    black.ArmorPhysicalResist = 10;
	    black.ArmorEnergyResist = -3;

	    CraftAttributeInfo green = GreenScales = new CraftAttributeInfo();

	    green.ArmorFireResist = -3;
	    green.ArmorPoisonResist = 10;

	    CraftAttributeInfo white = WhiteScales = new CraftAttributeInfo();

	    white.ArmorPhysicalResist = -3;
	    white.ArmorColdResist = 10;

	    CraftAttributeInfo blue = BlueScales = new CraftAttributeInfo();

	    blue.ArmorPoisonResist = -3;
	    blue.ArmorEnergyResist = 10;

	    //public static readonly CraftAttributeInfo OakWood, AshWood, YewWood, Heartwood, Bloodwood, Frostwood;

	    // CraftAttributeInfo oak = OakWood = new CraftAttributeInfo();

	    // CraftAttributeInfo ash = AshWood = new CraftAttributeInfo();

	    // CraftAttributeInfo yew = YewWood = new CraftAttributeInfo();

	    // CraftAttributeInfo heart = Heartwood = new CraftAttributeInfo();

	    // CraftAttributeInfo blood = Bloodwood = new CraftAttributeInfo();

	    // CraftAttributeInfo frost = Frostwood = new CraftAttributeInfo();
	}
    }

    public class CraftResourceInfo
    {
	private int m_Hue;
	private int m_Number;
	private string m_Name;
	private CraftAttributeInfo m_AttributeInfo;
	private CraftResource m_Resource;
	private Type[] m_ResourceTypes;

	public int Hue{ get{ return m_Hue; } }
	public int Number{ get{ return m_Number; } }
	public string Name{ get{ return m_Name; } }
	public CraftAttributeInfo AttributeInfo{ get{ return m_AttributeInfo; } }
	public CraftResource Resource{ get{ return m_Resource; } }
	public Type[] ResourceTypes{ get{ return m_ResourceTypes; } }

	public CraftResourceInfo( int hue, int number, string name, CraftAttributeInfo attributeInfo, CraftResource resource, params Type[] resourceTypes )
	{
	    m_Hue = hue;
	    m_Number = number;
	    m_Name = name;
	    m_AttributeInfo = attributeInfo;
	    m_Resource = resource;
	    m_ResourceTypes = resourceTypes;

	    for ( int i = 0; i < resourceTypes.Length; ++i )
		CraftResources.RegisterType( resourceTypes[i], resource );
	}
    }

    public class CraftResources
    {
	private static CraftResourceInfo[] m_MetalInfo = new CraftResourceInfo[]
	    {
		new CraftResourceInfo( 0x0, 1053109, "Iron", CraftAttributeInfo.Blank, CraftResource.Iron, typeof( IronIngot ), typeof( IronOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Gold", CraftAttributeInfo.Gold, CraftResource.Gold, typeof( GoldIngot ), typeof( GoldOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Spike", CraftAttributeInfo.Spike, CraftResource.Spike, typeof( SpikeIngot ), typeof( SpikeOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Fruity", CraftAttributeInfo.Fruity, CraftResource.Fruity, typeof( FruityIngot ), typeof( FruityOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Bronze", CraftAttributeInfo.Bronze, CraftResource.Bronze, typeof( BronzeIngot ), typeof( BronzeOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "IceRock", CraftAttributeInfo.IceRock, CraftResource.IceRock, typeof( IceRockIngot ), typeof( IceRockOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "BlackDwarf", CraftAttributeInfo.BlackDwarf, CraftResource.BlackDwarf, typeof( BlackDwarfIngot ), typeof( BlackDwarfOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "DullCopper", CraftAttributeInfo.DullCopper, CraftResource.DullCopper, typeof( DullCopperIngot ), typeof( DullCopperOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Platinum", CraftAttributeInfo.Platinum, CraftResource.Platinum, typeof( PlatinumIngot ), typeof( PlatinumOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "SilverRock", CraftAttributeInfo.SilverRock, CraftResource.SilverRock, typeof( SilverRockIngot ), typeof( SilverRockOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "DarkPagan", CraftAttributeInfo.DarkPagan, CraftResource.DarkPagan, typeof( DarkPaganIngot ), typeof( DarkPaganOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Copper", CraftAttributeInfo.Copper, CraftResource.Copper, typeof( CopperIngot ), typeof( CopperOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Mystic", CraftAttributeInfo.Mystic, CraftResource.Mystic, typeof( MysticIngot ), typeof( MysticOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Spectral", CraftAttributeInfo.Spectral, CraftResource.Spectral, typeof( SpectralIngot ), typeof( SpectralOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "OldBritain", CraftAttributeInfo.OldBritain, CraftResource.OldBritain, typeof( OldBritainIngot ), typeof( OldBritainOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Onyx", CraftAttributeInfo.Onyx, CraftResource.Onyx, typeof( OnyxIngot ), typeof( OnyxOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "RedElven", CraftAttributeInfo.RedElven, CraftResource.RedElven, typeof( RedElvenIngot ), typeof( RedElvenOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Undead", CraftAttributeInfo.Undead, CraftResource.Undead, typeof( UndeadIngot ), typeof( UndeadOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Pyrite", CraftAttributeInfo.Pyrite, CraftResource.Pyrite, typeof( PyriteIngot ), typeof( PyriteOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Virginity", CraftAttributeInfo.Virginity, CraftResource.Virginity, typeof( VirginityIngot ), typeof( VirginityOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Malachite", CraftAttributeInfo.Malachite, CraftResource.Malachite, typeof( MalachiteIngot ), typeof( MalachiteOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Lavarock", CraftAttributeInfo.Lavarock, CraftResource.Lavarock, typeof( LavarockIngot ), typeof( LavarockOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Azurite", CraftAttributeInfo.Azurite, CraftResource.Azurite, typeof( AzuriteIngot ), typeof( AzuriteOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Dripstone", CraftAttributeInfo.Dripstone, CraftResource.Dripstone, typeof( DripstoneIngot ), typeof( DripstoneOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Executor", CraftAttributeInfo.Executor, CraftResource.Executor, typeof( ExecutorIngot ), typeof( ExecutorOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Peachblue", CraftAttributeInfo.Peachblue, CraftResource.Peachblue, typeof( PeachblueIngot ), typeof( PeachblueOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Destruction", CraftAttributeInfo.Destruction, CraftResource.Destruction, typeof( DestructionIngot ), typeof( DestructionOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Anra", CraftAttributeInfo.Anra, CraftResource.Anra, typeof( AnraIngot ), typeof( AnraOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Crystal", CraftAttributeInfo.Crystal, CraftResource.Crystal, typeof( CrystalIngot ), typeof( CrystalOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Doom", CraftAttributeInfo.Doom, CraftResource.Doom, typeof( DoomIngot ), typeof( DoomOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "Goddess", CraftAttributeInfo.Goddess, CraftResource.Goddess, typeof( GoddessIngot ), typeof( GoddessOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "NewZulu", CraftAttributeInfo.NewZulu, CraftResource.NewZulu, typeof( NewZuluIngot ), typeof( NewZuluOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "DarkSableRuby", CraftAttributeInfo.DarkSableRuby, CraftResource.DarkSableRuby, typeof( DarkSableRubyIngot ), typeof( DarkSableRubyOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "EbonTwilightSapphire", CraftAttributeInfo.EbonTwilightSapphire, CraftResource.EbonTwilightSapphire, typeof( EbonTwilightSapphireIngot ), typeof( EbonTwilightSapphireOre ), typeof( Granite ) ),

		new CraftResourceInfo( 0x0, 1053109, "RadiantNimbusDiamond", CraftAttributeInfo.RadiantNimbusDiamond, CraftResource.RadiantNimbusDiamond, typeof( RadiantNimbusDiamondIngot ), typeof( RadiantNimbusDiamondOre ), typeof( Granite ) ),

	    };

	private static CraftResourceInfo[] m_ScaleInfo = new CraftResourceInfo[]
	    {
		new CraftResourceInfo( 0x66D, 1053129, "Red Scales",	CraftAttributeInfo.RedScales,		CraftResource.RedScales,		typeof( RedScales ) ),
		new CraftResourceInfo( 0x8A8, 1053130, "Yellow Scales",	CraftAttributeInfo.YellowScales,	CraftResource.YellowScales,		typeof( YellowScales ) ),
		new CraftResourceInfo( 0x455, 1053131, "Black Scales",	CraftAttributeInfo.BlackScales,		CraftResource.BlackScales,		typeof( BlackScales ) ),
		new CraftResourceInfo( 0x851, 1053132, "Green Scales",	CraftAttributeInfo.GreenScales,		CraftResource.GreenScales,		typeof( GreenScales ) ),
		new CraftResourceInfo( 0x8FD, 1053133, "White Scales",	CraftAttributeInfo.WhiteScales,		CraftResource.WhiteScales,		typeof( WhiteScales ) ),
		new CraftResourceInfo( 0x8B0, 1053134, "Blue Scales",	CraftAttributeInfo.BlueScales,		CraftResource.BlueScales,		typeof( BlueScales ) )
	    };

	private static CraftResourceInfo[] m_LeatherInfo = new CraftResourceInfo[]
	    {
		new CraftResourceInfo( 0x000, 1049353, "Normal",		CraftAttributeInfo.Blank,		CraftResource.RegularLeather,	typeof( Leather ),			typeof( Hides ) ),
		new CraftResourceInfo( 0x283, 1049354, "Spined",		CraftAttributeInfo.Spined,		CraftResource.SpinedLeather,	typeof( SpinedLeather ),	typeof( SpinedHides ) ),
		new CraftResourceInfo( 0x227, 1049355, "Horned",		CraftAttributeInfo.Horned,		CraftResource.HornedLeather,	typeof( HornedLeather ),	typeof( HornedHides ) ),
		new CraftResourceInfo( 0x1C1, 1049356, "Barbed",		CraftAttributeInfo.Barbed,		CraftResource.BarbedLeather,	typeof( BarbedLeather ),	typeof( BarbedHides ) )
	    };

	private static CraftResourceInfo[] m_AOSLeatherInfo = new CraftResourceInfo[]
	    {
		new CraftResourceInfo( 0x000, 1049353, "Normal",		CraftAttributeInfo.Blank,		CraftResource.RegularLeather,	typeof( Leather ),			typeof( Hides ) ),
		new CraftResourceInfo( 0x8AC, 1049354, "Spined",		CraftAttributeInfo.Spined,		CraftResource.SpinedLeather,	typeof( SpinedLeather ),	typeof( SpinedHides ) ),
		new CraftResourceInfo( 0x845, 1049355, "Horned",		CraftAttributeInfo.Horned,		CraftResource.HornedLeather,	typeof( HornedLeather ),	typeof( HornedHides ) ),
		new CraftResourceInfo( 0x851, 1049356, "Barbed",		CraftAttributeInfo.Barbed,		CraftResource.BarbedLeather,	typeof( BarbedLeather ),	typeof( BarbedHides ) ),
	    };

	private static CraftResourceInfo[] m_WoodInfo = new CraftResourceInfo[]
	    {
		new CraftResourceInfo( 0x000, 1011542, "Normal",		CraftAttributeInfo.Blank,		CraftResource.RegularWood,	typeof( Log ),			typeof( Board ) ),
		new CraftResourceInfo( 1132, 1011542, "Pinetree", CraftAttributeInfo.Pinetree, CraftResource.Pinetree, typeof( PinetreeLog ), typeof( PinetreeBoard) ),
		new CraftResourceInfo( 5716, 1011542, "Cherry", CraftAttributeInfo.Cherry, CraftResource.Cherry, typeof( CherryLog ), typeof( CherryBoard) ),
		new CraftResourceInfo( 1045, 1011542, "Oak", CraftAttributeInfo.Oak, CraftResource.Oak, typeof( OakLog ), typeof( OakBoard) ),
		new CraftResourceInfo( 515, 1011542, "Purple Passion", CraftAttributeInfo.PurplePassion, CraftResource.PurplePassion, typeof( PurplePassionLog ), typeof( PurplePassionBoard) ),
		new CraftResourceInfo( 48, 1011542, "Golden Reflection", CraftAttributeInfo.GoldenReflection, CraftResource.GoldenReflection, typeof( GoldenReflectionLog ), typeof( GoldenReflectionBoard) ),
		new CraftResourceInfo( 1285, 1011542, "Hardranger", CraftAttributeInfo.Hardranger, CraftResource.Hardranger, typeof( HardrangerLog ), typeof( HardrangerBoard) ),
		new CraftResourceInfo( 1162, 1011542, "Jadewood", CraftAttributeInfo.Jadewood, CraftResource.Jadewood, typeof( JadewoodLog ), typeof( JadewoodBoard) ),
		new CraftResourceInfo( 1109, 1011542, "Darkwood", CraftAttributeInfo.Darkwood, CraftResource.Darkwood, typeof( DarkwoodLog ), typeof( DarkwoodBoard) ),
		new CraftResourceInfo( 1154, 1011542, "Stonewood", CraftAttributeInfo.Stonewood, CraftResource.Stonewood, typeof( StonewoodLog ), typeof( StonewoodBoard) ),
		new CraftResourceInfo( 1176, 1011542, "Sunwood", CraftAttributeInfo.Sunwood, CraftResource.Sunwood, typeof( SunwoodLog ), typeof( SunwoodBoard) ),
		new CraftResourceInfo( 1284, 1011542, "Gauntlet", CraftAttributeInfo.Gauntlet, CraftResource.Gauntlet, typeof( GauntletLog ), typeof( GauntletBoard) ),
		new CraftResourceInfo( 1177, 1011542, "Swampwood", CraftAttributeInfo.Swampwood, CraftResource.Swampwood, typeof( SwampwoodLog ), typeof( SwampwoodBoard) ),
		new CraftResourceInfo( 1161, 1011542, "Stardust", CraftAttributeInfo.Stardust, CraftResource.Stardust, typeof( StardustLog ), typeof( StardustBoard) ),
		new CraftResourceInfo( 2301, 1011542, "Silver leaf", CraftAttributeInfo.Silverleaf, CraftResource.Silverleaf, typeof( SilverleafLog ), typeof( SilverleafBoard) ),
		new CraftResourceInfo( 1346, 1011542, "Stormteal", CraftAttributeInfo.Stormteal, CraftResource.Stormteal, typeof( StormtealLog ), typeof( StormtealBoard) ),
		new CraftResourceInfo( 1159, 1011542, "Emerald wood", CraftAttributeInfo.Emeraldwood, CraftResource.Emeraldwood, typeof( EmeraldwoodLog ), typeof( EmeraldwoodBoard) ),
		new CraftResourceInfo( 1645, 1011542, "Bloodwood", CraftAttributeInfo.Bloodwood, CraftResource.Bloodwood, typeof( BloodwoodLog ), typeof( BloodwoodBoard) ),
		new CraftResourceInfo( 1170, 1011542, "Crystal wood", CraftAttributeInfo.Crystalwood, CraftResource.Crystalwood, typeof( CrystalwoodLog ), typeof( CrystalwoodBoard) ),
		new CraftResourceInfo( 1287, 1011542, "Bloodhorse", CraftAttributeInfo.Bloodhorse, CraftResource.Bloodhorse, typeof( BloodhorseLog ), typeof( BloodhorseBoard) ),
		new CraftResourceInfo( 1183, 1011542, "Doom wood", CraftAttributeInfo.Doomwood, CraftResource.Doomwood, typeof( DoomwoodLog ), typeof( DoomwoodBoard) ),
		new CraftResourceInfo( 1160, 1011542, "Zulu", CraftAttributeInfo.Zulu, CraftResource.Zulu, typeof( ZuluLog ), typeof( ZuluBoard) ),
		new CraftResourceInfo( 1258, 1011542, "Darkness", CraftAttributeInfo.Darkness, CraftResource.Darkness, typeof( DarknessLog ), typeof( DarknessBoard) ),
		new CraftResourceInfo( 1165, 1011542, "Elven", CraftAttributeInfo.Elven, CraftResource.Elven, typeof( ElvenLog ), typeof( ElvenBoard) ),
	    };

	/// <summary>
	/// Returns true if '<paramref name="resource"/>' is None, Iron, RegularLeather or RegularWood. False if otherwise.
	/// </summary>
	public static bool IsStandard( CraftResource resource )
	{
	    return ( resource == CraftResource.None || resource == CraftResource.Iron || resource == CraftResource.RegularLeather || resource == CraftResource.RegularWood );
	}

	private static Dictionary<Type, CraftResource> m_TypeTable;

	/// <summary>
	/// Registers that '<paramref name="resourceType"/>' uses '<paramref name="resource"/>' so that it can later be queried by <see cref="CraftResources.GetFromType"/>
	/// </summary>
	public static void RegisterType( Type resourceType, CraftResource resource )
	{
	    if ( m_TypeTable == null )
		m_TypeTable = new Dictionary<Type, CraftResource>();

	    m_TypeTable[resourceType] = resource;
	}

	/// <summary>
	/// Returns the <see cref="CraftResource"/> value for which '<paramref name="resourceType"/>' uses -or- CraftResource.None if an unregistered type was specified.
	/// </summary>
	public static CraftResource GetFromType( Type resourceType )
	{
	    if ( m_TypeTable == null )
		return CraftResource.None;

	    CraftResource res;
			
	    if (!m_TypeTable.TryGetValue(resourceType, out res))
		return CraftResource.None;

	    return res;
	}

	/// <summary>
	/// Returns a <see cref="CraftResourceInfo"/> instance describing '<paramref name="resource"/>' -or- null if an invalid resource was specified.
	/// </summary>
	public static CraftResourceInfo GetInfo( CraftResource resource )
	{
	    CraftResourceInfo[] list = null;

	    switch ( GetType( resource ) )
	    {
		case CraftResourceType.Metal: list = m_MetalInfo; break;
		case CraftResourceType.Leather: list = Core.AOS ? m_AOSLeatherInfo : m_LeatherInfo; break;
		case CraftResourceType.Scales: list = m_ScaleInfo; break;
		case CraftResourceType.Wood: list = m_WoodInfo; break;
	    }

	    if ( list != null )
	    {
		int index = GetIndex( resource );

		if ( index >= 0 && index < list.Length )
		    return list[index];
	    }

	    return null;
	}

	/// <summary>
	/// Returns a <see cref="CraftResourceType"/> value indiciating the type of '<paramref name="resource"/>'.
	/// </summary>
	public static CraftResourceType GetType( CraftResource resource )
	{
	    if ( resource >= CraftResource.Iron && resource <= CraftResource.RadiantNimbusDiamond )
		return CraftResourceType.Metal;

	    if ( resource >= CraftResource.RegularLeather && resource <= CraftResource.BarbedLeather )
		return CraftResourceType.Leather;

	    if ( resource >= CraftResource.RedScales && resource <= CraftResource.BlueScales )
		return CraftResourceType.Scales;

	    if ( resource >= CraftResource.RegularWood && resource <= CraftResource.Elven )
		return CraftResourceType.Wood;

	    return CraftResourceType.None;
	}

	/// <summary>
	/// Returns the first <see cref="CraftResource"/> in the series of resources for which '<paramref name="resource"/>' belongs.
	/// </summary>
	public static CraftResource GetStart( CraftResource resource )
	{
	    switch ( GetType( resource ) )
	    {
		case CraftResourceType.Metal: return CraftResource.Iron;
		case CraftResourceType.Leather: return CraftResource.RegularLeather;
		case CraftResourceType.Scales: return CraftResource.RedScales;
		case CraftResourceType.Wood: return CraftResource.RegularWood;
	    }

	    return CraftResource.None;
	}

	/// <summary>
	/// Returns the index of '<paramref name="resource"/>' in the seriest of resources for which it belongs.
	/// </summary>
	public static int GetIndex( CraftResource resource )
	{
	    CraftResource start = GetStart( resource );

	    if ( start == CraftResource.None )
		return 0;

	    return (int)(resource - start);
	}

	/// <summary>
	/// Returns the <see cref="CraftResourceInfo.Number"/> property of '<paramref name="resource"/>' -or- 0 if an invalid resource was specified.
	/// </summary>
	public static int GetLocalizationNumber( CraftResource resource )
	{
	    CraftResourceInfo info = GetInfo( resource );

	    return ( info == null ? 0 : info.Number );
	}

	/// <summary>
	/// Returns the <see cref="CraftResourceInfo.Hue"/> property of '<paramref name="resource"/>' -or- 0 if an invalid resource was specified.
	/// </summary>
	public static int GetHue( CraftResource resource )
	{
	    CraftResourceInfo info = GetInfo( resource );

	    return ( info == null ? 0 : info.Hue );
	}

	/// <summary>
	/// Returns the <see cref="CraftResourceInfo.Name"/> property of '<paramref name="resource"/>' -or- an empty string if the resource specified was invalid.
	/// </summary>
	public static string GetName( CraftResource resource )
	{
	    CraftResourceInfo info = GetInfo( resource );

	    return ( info == null ? String.Empty : info.Name );
	}

    }

}
