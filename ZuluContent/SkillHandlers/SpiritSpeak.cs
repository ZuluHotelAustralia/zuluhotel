using System;
using System.Collections.Generic;
using System.Linq;
using Scripts.Zulu.Engines.Classes;
using Scripts.Zulu.Utilities;
using Server.Items;
using Server.Mobiles;
using Server.Spells;
using Server.Network;
using Server.Utilities;

namespace Server.SkillHandlers
{
    public static class SpiritSpeak
    {
        private static readonly Dictionary<Point3D, long> UsedGravestones = new();
        private static readonly long GravestoneCooldown = (int) TimeSpan.FromHours(6).TotalMilliseconds;
        
        private static readonly (string template, Type item)[] UndeadKnowledgeConfig =
        {
            ("Skeleton", typeof(ControlUndeadScroll)),
            ("SkeletonArcher", typeof(DarknessScroll)),
            ("Ghost", typeof(DecayingRayScroll)),
            ("BoneKnight", typeof(SpectresTouchScroll)),
            ("Wraith", typeof(AbyssalFlameScroll)),
            ("BoneMagician", typeof(AnimateDeadScroll)),
            ("Spectre", typeof(SacrificeScroll)),
            ("FlamingSkeleton", typeof(WraithsBreathScroll)),
            ("Revenant", typeof(SorcerersBaneScroll)),
            ("Frankenstein", typeof(SummonSpiritScroll)),
            ("Liche", typeof(WraithformScroll)),
            ("Daemon", typeof(WyvernStrikeScroll)),
            ("Bloodliche", typeof(KillScroll)),
            ("DaemonLieutenant", typeof(LicheScroll)),
        };

        public static void Initialize()
        {
            SkillInfo.Table[(int) SkillName.SpiritSpeak].Callback = OnUse;
        }

        public static TimeSpan OnUse(Mobile m)
        {
            m.RevealingAction();

            if (m.ShilCheckSkill(SkillName.SpiritSpeak))
            {
                if (!m.CanHearGhosts)
                {
                    var secs = m.Skills[SkillName.SpiritSpeak].Base / 50 * 90;
                    new SpiritSpeakTimer(m, TimeSpan.FromSeconds(secs < 15 ? 15 : secs)).Start();
                    m.CanHearGhosts = true;
                }

                m.PlaySound(0x24A);
                m.SendSuccessMessage(502444); //You contact the netherworld.
            }
            else
            {
                m.SendFailureMessage(502443); //You fail to contact the netherworld.
                m.CanHearGhosts = false;
            }
            
            if(m.CanHearGhosts)
                TryContactUndead(m);

            return ZhConfig.Skills.Entries[SkillName.SpiritSpeak].Delay;
        }

        private static async void TryContactUndead(Mobile m)
        {
            var stone = ZuluUtil.FindStaticTileByName(m, "gravestone", 1).FirstOrDefault();

            // Must be facing a gravestone
            if (stone == default || (m.Direction & Direction.Mask) != m.GetDirectionTo(stone))
                return;
            
            // 1 in 20 chance this is a gravestone that can be channeled
            // In a large graveyard like Vesper on average only 4-5 graves can be channelled 
            if (!UsedGravestones.ContainsKey(stone) && Utility.RandomDouble() > 0.05)
            {
                // Set an effectively infinite cooldown
                UsedGravestones[stone] = long.MaxValue;
            }
            
            // Anh Mi Sah Ko
            m.PublicOverheadMessage(MessageType.Regular, 0x3B2, 1062074, "", false);
            m.PlaySound(0x24A);
            // Bow
            m.Animate(32, 5, 1, true, false, 0);

            await Timer.Pause(1000);
            // Stone on cooldown
            if (UsedGravestones.TryGetValue(stone, out var cd) && cd > Core.TickCount)
            {
                m.SendFailureMessage(cd == long.MaxValue 
                    ? "You reach out to the grave's spirit but find nothing of interest..." 
                    : "This grave seems to have been disturbed recently..."
                );
                return;
            }
            
            var level = Utility.Random(0, UndeadKnowledgeConfig.Length);

            if (!m.ShilCheckSkill(SkillName.SpiritSpeak, level * 6, 0))
            {
                m.SendFailureMessage("You sense the presence of a dark spirit but fail to channel it.");
                UsedGravestones[stone] = 0; // Allow them to attempt again
                return;
            }
            
            m.SendSuccessMessage("Your connection to the netherworld is so strong you channel the dark spirit tied to the gravestone!");
            
            // Set cooldown on success
            UsedGravestones[stone] = Core.TickCount + GravestoneCooldown;
            
            // Paralyze
            m.PlaySound(0x204);
            m.FixedEffect(0x376A, 6, 1);
            m.Paralyzed = true;

            await Timer.Pause(3000);

            m.LocalOverheadMessage(MessageType.Emote, 0, true, "*Your body moves on its own as you become possessed by a dark spirit!*");
            
            // Ensure we can spawn a creature here
            if (!SpellHelper.FindValidSpawnLocation(m.Map, ref stone, true))
            {
                // Fizzle
                m.FixedEffect(0x3735, 6, 30);
                m.PlaySound(0x5C);
                m.SendFailureMessage("You regain your senses as something in the region blocks the spirits energy...");
                
                m.Paralyzed = false;
                return;
            }

            m.FixedParticles(14089 + Utility.Random(4), 1, 15, 9501, 2100, 4, EffectLayer.Waist);
            Effects.PlaySound(m.Location, m.Map, 0x107);
            m.Direction = m.GetDirectionTo(stone);
            
            for (var i = 0; i < 3; i++)
            {
                // Summoning anim
                m.Animate(0x10D, 7, 3, true, false, 0);
                await Timer.Pause(1000);
            }
            
            var (creatureType, itemType) = UndeadKnowledgeConfig[level];

            BaseCreature creature = creatureType;
            creature.Summoned = true;
            creature.Blessed = true; // Invulnerable
            creature.BardImmune = true;
            creature.MoveToWorld(stone, m.Map);
            creature.AIObject.Deactivate();
            creature.PlaySound(creature.GetIdleSound());
            creature.Direction = creature.GetDirectionTo(m);

            await Timer.Pause(2000);

            creature.PublicOverheadMessage(MessageType.Yell, 33, true, "You dare disturb me in search of knowledge...");

            await Timer.Pause(5000);

            if (!m.ShilCheckSkill(SkillName.SpiritSpeak, level * 8, 0))
            {
                creature.PublicOverheadMessage(MessageType.Yell, 33, true, "I give you only death!");

                await Timer.Pause(2000);

                creature.AIObject.Activate();
                creature.Blessed = false;
                m.Paralyzed = false;
                // Give AI time to activate
                await Timer.Pause(100);

                creature.PlaySound(creature.GetAngerSound());
                creature.Attack(m);
            }
            else
            {
                creature.PublicOverheadMessage(MessageType.Yell, 33, true, "I give you only this! Now leave me!");

                var reward = itemType.CreateInstance<Item>();
                var regs = Reagent.NecroReagents.RandomElement().CreateInstance<Item>();
                
                reward.Amount = 1;
                regs.Amount = level;

                reward.MoveToWorld(stone, m.Map);
                regs.MoveToWorld(stone, m.Map);
                
                await Timer.Pause(5000);
                creature.Dispel(creature);
                
                reward.OnSingleClick(m);

                m.Paralyzed = false;
            }
        }

        private class SpiritSpeakTimer : Timer
        {
            private readonly Mobile m_Owner;

            public SpiritSpeakTimer(Mobile m, TimeSpan duration) : base(duration)
            {
                m_Owner = m;
                Priority = TimerPriority.FiveSeconds;
            }

            protected override void OnTick()
            {
                m_Owner.CanHearGhosts = false;
                m_Owner.SendLocalizedMessage(502445); //You feel your contact with the netherworld fading.
            }
        }
    }
}