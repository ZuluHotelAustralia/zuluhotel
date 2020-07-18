using System;
using Earth = RunZH.Scripts.Zulu.Spells.Earth;
using Necromancy = RunZH.Scripts.Zulu.Spells.Necromancy;

namespace Server.Spells
{
    public class Initializer
    {
        public static void Initialize()
        {
            // First circle
            Register(00, typeof(First.ClumsySpell));
            Register(01, typeof(First.CreateFoodSpell));
            Register(02, typeof(First.FeeblemindSpell));
            Register(03, typeof(First.HealSpell));
            Register(04, typeof(First.MagicArrowSpell));
            Register(05, typeof(First.NightSightSpell));
            Register(06, typeof(First.ReactiveArmorSpell));
            Register(07, typeof(First.WeakenSpell));

            // Second circle
            Register(08, typeof(Second.AgilitySpell));
            Register(09, typeof(Second.CunningSpell));
            Register(10, typeof(Second.CureSpell));
            Register(11, typeof(Second.HarmSpell));
            Register(12, typeof(Second.MagicTrapSpell));
            Register(13, typeof(Second.RemoveTrapSpell));
            Register(14, typeof(Second.ProtectionSpell));
            Register(15, typeof(Second.StrengthSpell));

            // Third circle
            Register(16, typeof(Third.BlessSpell));
            Register(17, typeof(Third.FireballSpell));
            Register(18, typeof(Third.MagicLockSpell));
            Register(19, typeof(Third.PoisonSpell));
            Register(20, typeof(Third.TelekinesisSpell));
            Register(21, typeof(Third.TeleportSpell));
            Register(22, typeof(Third.UnlockSpell));
            Register(23, typeof(Third.WallOfStoneSpell));

            // Fourth circle
            Register(24, typeof(Fourth.ArchCureSpell));
            Register(25, typeof(Fourth.ArchProtectionSpell));
            Register(26, typeof(Fourth.CurseSpell));
            Register(27, typeof(Fourth.FireFieldSpell));
            Register(28, typeof(Fourth.GreaterHealSpell));
            Register(29, typeof(Fourth.LightningSpell));
            Register(30, typeof(Fourth.ManaDrainSpell));
            Register(31, typeof(Fourth.RecallSpell));

            // Fifth circle
            Register(32, typeof(Fifth.BladeSpiritsSpell));
            Register(33, typeof(Fifth.DispelFieldSpell));
            Register(34, typeof(Fifth.IncognitoSpell));
            Register(35, typeof(Fifth.MagicReflectSpell));
            Register(36, typeof(Fifth.MindBlastSpell));
            Register(37, typeof(Fifth.ParalyzeSpell));
            Register(38, typeof(Fifth.PoisonFieldSpell));
            Register(39, typeof(Fifth.SummonCreatureSpell));

            // Sixth circle
            Register(40, typeof(Sixth.DispelSpell));
            Register(41, typeof(Sixth.EnergyBoltSpell));
            Register(42, typeof(Sixth.ExplosionSpell));
            Register(43, typeof(Sixth.InvisibilitySpell));
            Register(44, typeof(Sixth.MarkSpell));
            Register(45, typeof(Sixth.MassCurseSpell));
            Register(46, typeof(Sixth.ParalyzeFieldSpell));
            Register(47, typeof(Sixth.RevealSpell));

            // Seventh circle
            Register(48, typeof(Seventh.ChainLightningSpell));
            Register(49, typeof(Seventh.EnergyFieldSpell));
            Register(50, typeof(Seventh.FlameStrikeSpell));
            Register(51, typeof(Seventh.GateTravelSpell));
            Register(52, typeof(Seventh.ManaVampireSpell));
            Register(53, typeof(Seventh.MassDispelSpell));
            Register(54, typeof(Seventh.MeteorSwarmSpell));
            Register(55, typeof(Seventh.PolymorphSpell));

            // Eighth circle
            Register(56, typeof(Eighth.EarthquakeSpell));
            Register(57, typeof(Eighth.EnergyVortexSpell));
            Register(58, typeof(Eighth.ResurrectionSpell));
            Register(59, typeof(Eighth.AirElementalSpell));
            Register(60, typeof(Eighth.SummonDaemonSpell));
            Register(61, typeof(Eighth.EarthElementalSpell));
            Register(62, typeof(Eighth.FireElementalSpell));
            Register(63, typeof(Eighth.WaterElementalSpell));

            Register(100, typeof(Necromancy.ControlUndeadSpell));
            Register(101, typeof(Necromancy.DarknessSpell));
            Register(102, typeof(Necromancy.DecayingRaySpell));
            Register(103, typeof(Necromancy.SpectresTouchSpell));
            Register(104, typeof(Necromancy.AbyssalFlameSpell));
            Register(105, typeof(Necromancy.AnimateDeadSpell));
            Register(106, typeof(Necromancy.SacrificeSpell));
            Register(107, typeof(Necromancy.WraithBreathSpell));
            Register(108, typeof(Necromancy.SorcerorsBaneSpell));
            Register(109, typeof(Necromancy.SummonSpiritSpell));
            Register(110, typeof(Necromancy.WraithFormSpell));
            Register(111, typeof(Necromancy.WyvernStrikeSpell));
            Register(112, typeof(Necromancy.KillSpell));
            Register(113, typeof(Necromancy.LicheFormSpell));
            Register(114, typeof(Necromancy.PlagueSpell));
            Register(115, typeof(Necromancy.SpellbindSpell));

            Register(600, typeof(Earth.AntidoteSpell));
            Register(601, typeof(Earth.OwlSightSpell));
            Register(602, typeof(Earth.ShiftingEarthSpell));
            Register(603, typeof(Earth.SummonMammalsSpell));
            Register(604, typeof(Earth.CallLightningSpell));
            Register(605, typeof(Earth.EarthsBlessingSpell));
            Register(606, typeof(Earth.EarthPortalSpell));
            Register(607, typeof(Earth.NaturesTouchSpell));
            Register(608, typeof(Earth.GustOfAirSpell));
            Register(609, typeof(Earth.RisingFireSpell));
            Register(610, typeof(Earth.ShapeshiftSpell));
            Register(611, typeof(Earth.IceStrikeSpell));
            Register(612, typeof(Earth.EarthSpiritSpell));
            Register(613, typeof(Earth.FireSpiritSpell));
            Register(614, typeof(Earth.StormSpiritSpell));
            Register(615, typeof(Earth.WaterSpiritSpell));
        }

        public static void Register(int spellID, Type type)
        {
            SpellRegistry.Register(spellID, type);
        }
    }
}