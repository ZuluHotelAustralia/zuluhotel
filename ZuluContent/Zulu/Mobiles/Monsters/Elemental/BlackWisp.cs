using System;
using System.Collections.Generic;
using Scripts.Zulu.Spells.Necromancy;
using Server;
using Server.Misc;
using Server.Items;
using static Server.Mobiles.CreatureProp;
using Server.Engines.Magic;
using Server.Engines.Harvest;

namespace Server.Mobiles
{
    public class BlackWisp : BaseCreature
    {
        static BlackWisp()
        {
            CreatureProperties.Register<BlackWisp>(new CreatureProperties
            {
                // cast_pct = 40,
                // CProp_Permmr = i8,
                // DataElementId = blackwisp,
                // DataElementType = NpcTemplate,
                // dstart = 10,
                // Equip = blackwisp,
                // Graphic = 0x0ec4 /* Weapon */,
                // Hitscript = :combat:banishscript /* Weapon */,
                // HitSound = 0x1D5 /* Weapon */,
                // hostile = 1,
                LootTable = "35",
                LootItemChance = 75,
                LootItemLevel = 5,
                // MissSound = 0x239 /* Weapon */,
                // num_casts = 8,
                // script = spellkillpcs,
                // speech = 7,
                // Speed = 35 /* Weapon */,
                // spell = ebolt,
                // spell_0 = flamestrike,
                // spell_1 = lightning,
                // spell_2 = explosion,
                // spell_3 = masscurse,
                // spell_4 = abyssalflame,
                // spell_5 = wyvernstrike,
                // spell_6 = spectretouch,
                // spell_7 = sorcerersbane,
                // spell_8 = wraithbreath,
                // spell_9 = decayingray,
                // TrueColor = 0x0455,
                ActiveSpeed = 0.2,
                AiType = AIType.AI_Mage /* spellkillpcs */,
                AlwaysMurderer = true,
                AutoDispel = true,
                Body = 0x3a,
                CorpseNameOverride = "corpse of a black wisp",
                CreatureType = CreatureType.Elemental,
                DamageMax = 64,
                DamageMin = 8,
                Dex = 575,
                Female = false,
                FightMode = FightMode.Closest,
                FightRange = 1,
                HitsMax = 700,
                Hue = 0x0455,
                Int = 1100,
                ManaMaxSeed = 1100,
                Name = "a black wisp",
                PassiveSpeed = 0.4,
                PerceptionRange = 10,
                PreferredSpells = new List<Type>
                {
                    typeof(Spells.Sixth.EnergyBoltSpell),
                    typeof(Spells.Fourth.LightningSpell),
                    typeof(Spells.Sixth.ExplosionSpell),
                    typeof(Spells.Sixth.MassCurseSpell),
                    typeof(AbyssalFlameSpell),
                    typeof(WyvernStrikeSpell),
                    typeof(SpectresTouchSpell),
                    typeof(SorcerersBaneSpell),
                    typeof(WraithBreathSpell),
                    typeof(DecayingRaySpell)
                },
                ProvokeSkillOverride = 120,
                Resistances = new Dictionary<ElementalType, CreatureProp>()
                {
                    {ElementalType.Necro, 100},
                    {ElementalType.Earth, 100},
                    {ElementalType.MagicImmunity, 6}
                },
                Skills = new Dictionary<SkillName, CreatureProp>
                {
                    {SkillName.Tactics, 100},
                    {SkillName.Macing, 100},
                    {SkillName.MagicResist, 200},
                    {SkillName.Magery, 200},
                    {SkillName.EvalInt, 200}
                },
                StamMaxSeed = 175,
                Str = 700,
                VirtualArmor = 30
            });
        }


        [Constructible]
        public BlackWisp() : base(CreatureProperties.Get<BlackWisp>())
        {
            // Add customization here

            AddItem(new SkinningKnife
            {
                Movable = false,
                Name = "Blackwisp Weapon",
                Speed = 35,
                MaxHitPoints = 250,
                HitPoints = 250,
                HitSound = 0x1D5,
                MissSound = 0x239
            });
        }

        [Constructible]
        public BlackWisp(Serial serial) : base(serial)
        {
        }


        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int) 0);
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);
            var version = reader.ReadInt();
        }
    }
}