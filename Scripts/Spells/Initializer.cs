using System;
using Server;

namespace Server.Spells
{
    public class Initializer
    {
	public static void Initialize()
	{
	    // First circle
	    Register( 00, typeof( First.ClumsySpell ) );
	    Register( 01, typeof( First.CreateFoodSpell ) );
	    Register( 02, typeof( First.FeeblemindSpell ) );
	    Register( 03, typeof( First.HealSpell ) );
	    Register( 04, typeof( First.MagicArrowSpell ) );
	    Register( 05, typeof( First.NightSightSpell ) );
	    Register( 06, typeof( First.ReactiveArmorSpell ) );
	    Register( 07, typeof( First.WeakenSpell ) );

	    // Second circle
	    Register( 08, typeof( Second.AgilitySpell ) );
	    Register( 09, typeof( Second.CunningSpell ) );
	    Register( 10, typeof( Second.CureSpell ) );
	    Register( 11, typeof( Second.HarmSpell ) );
	    Register( 12, typeof( Second.MagicTrapSpell ) );
	    Register( 13, typeof( Second.RemoveTrapSpell ) );
	    Register( 14, typeof( Second.ProtectionSpell ) );
	    Register( 15, typeof( Second.StrengthSpell ) );

	    // Third circle
	    Register( 16, typeof( Third.BlessSpell ) );
	    Register( 17, typeof( Third.FireballSpell ) );
	    Register( 18, typeof( Third.MagicLockSpell ) );
	    Register( 19, typeof( Third.PoisonSpell ) );
	    Register( 20, typeof( Third.TelekinesisSpell ) );
	    Register( 21, typeof( Third.TeleportSpell ) );
	    Register( 22, typeof( Third.UnlockSpell ) );
	    Register( 23, typeof( Third.WallOfStoneSpell ) );

	    // Fourth circle
	    Register( 24, typeof( Fourth.ArchCureSpell ) );
	    Register( 25, typeof( Fourth.ArchProtectionSpell ) );
	    Register( 26, typeof( Fourth.CurseSpell ) );
	    Register( 27, typeof( Fourth.FireFieldSpell ) );
	    Register( 28, typeof( Fourth.GreaterHealSpell ) );
	    Register( 29, typeof( Fourth.LightningSpell ) );
	    Register( 30, typeof( Fourth.ManaDrainSpell ) );
	    Register( 31, typeof( Fourth.RecallSpell ) );

	    // Fifth circle
	    Register( 32, typeof( Fifth.BladeSpiritsSpell ) );
	    Register( 33, typeof( Fifth.DispelFieldSpell ) );
	    Register( 34, typeof( Fifth.IncognitoSpell ) );
	    Register( 35, typeof( Fifth.MagicReflectSpell ) );
	    Register( 36, typeof( Fifth.MindBlastSpell ) );
	    Register( 37, typeof( Fifth.ParalyzeSpell ) );
	    Register( 38, typeof( Fifth.PoisonFieldSpell ) );
	    Register( 39, typeof( Fifth.SummonCreatureSpell ) );

	    // Sixth circle
	    Register( 40, typeof( Sixth.DispelSpell ) );
	    Register( 41, typeof( Sixth.EnergyBoltSpell ) );
	    Register( 42, typeof( Sixth.ExplosionSpell ) );
	    Register( 43, typeof( Sixth.InvisibilitySpell ) );
	    Register( 44, typeof( Sixth.MarkSpell ) );
	    Register( 45, typeof( Sixth.MassCurseSpell ) );
	    Register( 46, typeof( Sixth.ParalyzeFieldSpell ) );
	    Register( 47, typeof( Sixth.RevealSpell ) );

	    // Seventh circle
	    Register( 48, typeof( Seventh.ChainLightningSpell ) );
	    Register( 49, typeof( Seventh.EnergyFieldSpell ) );
	    Register( 50, typeof( Seventh.FlameStrikeSpell ) );
	    Register( 51, typeof( Seventh.GateTravelSpell ) );
	    Register( 52, typeof( Seventh.ManaVampireSpell ) );
	    Register( 53, typeof( Seventh.MassDispelSpell ) );
	    Register( 54, typeof( Seventh.MeteorSwarmSpell ) );
	    Register( 55, typeof( Seventh.PolymorphSpell ) );

	    // Eighth circle
	    Register( 56, typeof( Eighth.EarthquakeSpell ) );
	    Register( 57, typeof( Eighth.EnergyVortexSpell ) );
	    Register( 58, typeof( Eighth.ResurrectionSpell ) );
	    Register( 59, typeof( Eighth.AirElementalSpell ) );
	    Register( 60, typeof( Eighth.SummonDaemonSpell ) );
	    Register( 61, typeof( Eighth.EarthElementalSpell ) );
	    Register( 62, typeof( Eighth.FireElementalSpell ) );
	    Register( 63, typeof( Eighth.WaterElementalSpell ) );

	    // (Zulu, not OSI) Necromancy spells
	    Register( 100, typeof( Necromancy.ControlUndeadSpell ) );
	    Register( 101, typeof( Necromancy.DarknessSpell ) );
	    Register( 102, typeof( Necromancy.DecayingRaySpell ) );
	    Register( 103, typeof( Necromancy.SpectresTouchSpell ) );
	    Register( 104, typeof( Necromancy.AbyssalFlameSpell ) );
	    Register( 105, typeof( Necromancy.ZuluAnimateDeadSpell ) );
	    Register( 106, typeof( Necromancy.SacrificeSpell ) );
	    Register( 107, typeof( Necromancy.WraithBreathSpell ) );
	    Register( 108, typeof( Necromancy.SorcerorsBaneSpell ) );
	    Register( 109, typeof( Necromancy.SummonSpiritSpell ) );
	    Register( 110, typeof( Necromancy.ZuluWraithFormSpell ) );
	    Register( 111, typeof( Necromancy.WyvernStrikeSpell ) );
	    Register( 112, typeof( Necromancy.KillSpell ) );
	    Register( 113, typeof( Necromancy.LicheFormSpell ) );
	    Register( 114, typeof( Necromancy.PlagueSpell ) );
	    Register( 115, typeof( Necromancy.SpellbindSpell ) );

	    // Earth Spells to replace SpellweavingSpells
	    Register( 600, typeof( Spellweaving.AntidoteSpell ) );
	    Register( 601, typeof( Spellweaving.OwlSightSpell ) );
	    Register( 602, typeof( Spellweaving.ShiftingEarthSpell ) );
	    Register( 603, typeof( Spellweaving.SummonMammalsSpell ) );
	    Register( 604, typeof( Spellweaving.CallLightningSpell ) );
	    Register( 605, typeof( Spellweaving.EarthsBlessingSpell ) );
	    Register( 606, typeof( Spellweaving.EarthPortalSpell ) );
	    Register( 607, typeof( Spellweaving.NaturesTouchSpell ) );
	    Register( 608, typeof( Spellweaving.GustOfAirSpell ) );
	    Register( 610, typeof( Spellweaving.RisingFireSpell ) );
	    Register( 612, typeof( Spellweaving.ShapeshiftSpell ) );
	    Register( 613, typeof( Spellweaving.IceStrikeSpell ) );
	    Register( 614, typeof( Spellweaving.EarthSpiritSpell ) );
	    Register( 615, typeof( Spellweaving.FireSpiritSpell ) );
	    Register( 616, typeof( Spellweaving.StormSpiritSpell ) );
	    Register( 617, typeof( Spellweaving.WaterSpiritSpell ) );

	    if ( Core.AOS ) //this can probably just be deleted dbh, but I'll keep it for reference --sith
	    {

		if( Core.SE )
		    Register( 116, typeof( Necromancy.ExorcismSpell ) );

		// Paladin abilities
		Register( 200, typeof( Chivalry.CleanseByFireSpell ) );
		Register( 201, typeof( Chivalry.CloseWoundsSpell ) );
		Register( 202, typeof( Chivalry.ConsecrateWeaponSpell ) );
		Register( 203, typeof( Chivalry.DispelEvilSpell ) );
		Register( 204, typeof( Chivalry.DivineFurySpell ) );
		Register( 205, typeof( Chivalry.EnemyOfOneSpell ) );
		Register( 206, typeof( Chivalry.HolyLightSpell ) );
		Register( 207, typeof( Chivalry.NobleSacrificeSpell ) );
		Register( 208, typeof( Chivalry.RemoveCurseSpell ) );
		Register( 209, typeof( Chivalry.SacredJourneySpell ) );

		if ( Core.SE )
		{
		    // Samurai abilities
		    Register( 400, typeof( Bushido.HonorableExecution ) );
		    Register( 401, typeof( Bushido.Confidence ) );
		    Register( 402, typeof( Bushido.Evasion ) );
		    Register( 403, typeof( Bushido.CounterAttack ) );
		    Register( 404, typeof( Bushido.LightningStrike ) );
		    Register( 405, typeof( Bushido.MomentumStrike ) );

		    // Ninja abilities
		    Register( 500, typeof( Ninjitsu.FocusAttack ) );
		    Register( 501, typeof( Ninjitsu.DeathStrike ) );
		    Register( 502, typeof( Ninjitsu.AnimalForm ) );
		    Register( 503, typeof( Ninjitsu.KiAttack ) );
		    Register( 504, typeof( Ninjitsu.SurpriseAttack ) );
		    Register( 505, typeof( Ninjitsu.Backstab ) );
		    Register( 506, typeof( Ninjitsu.Shadowjump ) );
		    Register( 507, typeof( Ninjitsu.MirrorImage ) );
		}
	    }
	}

	public static void Register( int spellID, Type type )
	{
	    SpellRegistry.Register( spellID, type );
	}
    }
}
