using System;
using System.Collections.Generic;
using Server;
using Server.Misc;
using Server.Items;
using static Server.Mobiles.CreatureProp;
using Server.Engines.Magic;
using Server.Engines.Harvest;
using Scripts.Zulu.Engines.Classes;

namespace Server.Mobiles
{
    public class GoblinTribeMaster : BaseCreature
    {
        static GoblinTribeMaster()
        {
            CreatureProperties.Register<GoblinTribeMaster>(new CreatureProperties
            {
                // CProp_BaseHpRegen = i1000,
                // CProp_NoReactiveArmour = i1,
                // CProp_NoReactiveArmour_0 = i1,
                // CProp_untamemountatdeath = i1,
                // DataElementId = goblintribemaster,
                // DataElementType = NpcTemplate,
                // Equip = goblintribemaster,
                // Graphic = 0x1438 /* Weapon */,
                // Hitscript = :combat:paralyzehit /* Weapon */,
                // HitSound = 0x13C /* Weapon */,
                // hostile = 1,
                LootTable = "9",
                LootItemChance = 50,
                LootItemLevel = 6,
                // MissSound = 0x234 /* Weapon */,
                // mount = 0x3ea4 2001,
                // mounttemplate = frenziedpoisonostard,
                // script = killpcsTeleporter,
                // Speed = 51 /* Weapon */,
                // TrueColor = 34186,
                AiType = AIType.AI_Melee /* killpcsTeleporter */,
                AlwaysMurderer = true,
                BardImmune = true,
                Body = 0x190,
                ClassLevel = 5,
                ClassType = ZuluClassType.Warrior,
                CorpseNameOverride = "corpse of <random> the Goblin Tribe Master",
                CreatureType = CreatureType.Orc,
                DamageMax = 50,
                DamageMin = 10,
                Dex = 400,
                Female = false,
                FightMode = FightMode.Aggressor,
                FightRange = 1,
                HitsMax = 2250,
                Hue = 34186,
                Int = 55,
                ManaMaxSeed = 0,
                Name = "<random> the Goblin Tribe Master",
                PerceptionRange = 10,
                Resistances = new Dictionary<ElementalType, CreatureProp>
                {
                    {ElementalType.Fire, 75},
                    {ElementalType.Air, 75},
                    {ElementalType.Water, 75},
                    {ElementalType.Poison, 6},
                    {ElementalType.Earth, 75},
                    {ElementalType.Necro, 75}
                },
                Skills = new Dictionary<SkillName, CreatureProp>
                {
                    {SkillName.Tactics, 250},
                    {SkillName.Macing, 175},
                    {SkillName.MagicResist, 60},
                    {SkillName.DetectHidden, 200}
                },
                StamMaxSeed = 200,
                Str = 2250,
                TargetAcquireExhaustion = true,
                VirtualArmor = 50
            });
        }


        [Constructible]
        public GoblinTribeMaster() : base(CreatureProperties.Get<GoblinTribeMaster>())
        {
            // Add customization here

            AddItem(new OrcHelm
            {
                Movable = false,
                Name = "Goblin Helmet",
                Hue = 1418,
                BaseArmorRating = 18,
                MaxHitPoints = 400,
                HitPoints = 400
            });

            AddItem(new WarHammer
            {
                Movable = false,
                Name = "Goblin Tribe Master Weapon",
                Speed = 51,
                HitSound = 0x13C,
                MissSound = 0x234,
                MaxHitPoints = 110,
                HitPoints = 110,
                Animation = (WeaponAnimation) 0x000b
            });
        }

        [Constructible]
        public GoblinTribeMaster(Serial serial) : base(serial)
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