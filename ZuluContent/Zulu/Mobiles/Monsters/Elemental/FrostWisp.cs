using System;
using System.Collections.Generic;
using Scripts.Zulu.Spells.Earth;
using Scripts.Zulu.Spells.Necromancy;
using Server;
using Server.Misc;
using Server.Items;
using static Server.Mobiles.CreatureProp;
using Server.Engines.Magic;
using Server.Engines.Harvest;

namespace Server.Mobiles
{
    public class FrostWisp : BaseCreature
    {
        static FrostWisp()
        {
            CreatureProperties.Register<FrostWisp>(new CreatureProperties
            {
                // cast_pct = 40,
                // CProp_Permmr = i8,
                // DataElementId = frostwisp,
                // DataElementType = NpcTemplate,
                // dstart = 10,
                // Equip = blackwisp,
                // EvaluatingIntelligence_0 = 200,
                // Graphic = 0x0ec4 /* Weapon */,
                // Hitscript = :combat:banishscript /* Weapon */,
                // HitSound = 0x1D5 /* Weapon */,
                // hostile = 1,
                LootTable = "35",
                LootItemChance = 80,
                LootItemLevel = 6,
                // MissSound = 0x239 /* Weapon */,
                // num_casts = 8,
                // script = spellkillpcs,
                // speech = 7,
                // Speed = 35 /* Weapon */,
                // spell = kill,
                // spell_0 = icestrike,
                // spell_1 = calllightning,
                // spell_2 = masscurse,
                // spell_3 = plague,
                // spell_4 = wyvernstrike,
                // spell_5 = sorcerersbane,
                // TrueColor = 1154,
                ActiveSpeed = 0.2,
                AiType = AIType.AI_Mage /* spellkillpcs */,
                AlwaysMurderer = true,
                AutoDispel = true,
                Body = 0x3a,
                CorpseNameOverride = "corpse of a frost wisp",
                CreatureType = CreatureType.Elemental,
                DamageMax = 64,
                DamageMin = 8,
                Dex = 575,
                Female = false,
                FightMode = FightMode.Closest,
                FightRange = 1,
                HitsMax = 650,
                Hue = 1154,
                Int = 1600,
                ManaMaxSeed = 100,
                Name = "a frost wisp",
                PassiveSpeed = 0.4,
                PerceptionRange = 10,
                PreferredSpells = new List<Type>
                {
                    typeof(WyvernStrikeSpell),
                    typeof(IceStrikeSpell),
                    typeof(CallLightningSpell),
                    typeof(Spells.Sixth.MassCurseSpell),
                    typeof(PlagueSpell),
                    typeof(WyvernStrikeSpell),
                    typeof(SorcerersBaneSpell)
                },
                ProvokeSkillOverride = 130,
                Resistances = new Dictionary<ElementalType, CreatureProp>
                {
                    {ElementalType.Water, 100},
                    {ElementalType.Necro, 100},
                    {ElementalType.Earth, 100},
                    {ElementalType.MagicImmunity, 6}
                },
                Skills = new Dictionary<SkillName, CreatureProp>
                {
                    {SkillName.EvalInt, 200},
                    {SkillName.Tactics, 100},
                    {SkillName.Macing, 100},
                    {SkillName.MagicResist, 200},
                    {SkillName.Magery, 200}
                },
                StamMaxSeed = 175,
                Str = 900,
                VirtualArmor = 30
            });
        }


        [Constructible]
        public FrostWisp() : base(CreatureProperties.Get<FrostWisp>())
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
        public FrostWisp(Serial serial) : base(serial)
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