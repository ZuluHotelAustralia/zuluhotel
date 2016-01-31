using System;
using System.Collections;
using Server.Network;
using Server.Items;
using Server.Targeting;

namespace Server.Spells.Necromancy
{
    public class DecayingRaySpell : NecromancerSpell
    {
        private static SpellInfo m_Info = new SpellInfo("Decaying Ray", "Umbra Aufero Vita");
//                                                    Reagent.VialOfBlood, Reagent.VialOfBlood,
//                                                    Reagent.VolcanicAsh, Reagent.DaemonBone);

        public override TimeSpan CastDelayBase { get { return TimeSpan.FromSeconds( 1.0 ); } }
        public override double RequiredSkill { get { return 80.0; } }
        public override int RequiredMana { get { return 40; } }

        public DecayingRaySpell( Mobile caster, Item scroll ) : base ( caster, scroll, m_Info )
        {
        }

        public override void OnCast()
        {
            Caster.Target = new InternalTarget ( this );
        }

        public void Target( Mobile m )
        {
            if ( ! Caster.CanSee( m ) )
            {
                // Seems like this should be responsibility of the targetting system.  --daleron
                Caster.SendLocalizedMessage( 500237 ); // Target can not be seen.
                goto Return;
            }

            if ( ! CheckSequence() )
            {
                goto Return;
            }

            // Prevent stacking of DecayingRay.
            if ( ! m.BeginAction( typeof( DecayingRaySpell ) ) ) {
                goto Return;
            }

            // Turn caster towards the target.
            SpellHelper.Turn( Caster, m );

            // TODO: Spell Effects.

            Caster.DoHarmful( m );

            // TODO: Compute an appropriate mod value.
            int val = 10;

            m.VirtualArmorMod -= val;

            new InternalTimer( m, Caster, val ).Start();

        Return:
            FinishSequence();
        }

        private class InternalTimer : Timer
        {
            private Mobile m_Target;
            private int m_Value;

            public InternalTimer( Mobile target, Mobile caster, int value ) : base( TimeSpan.FromSeconds( 0 ) )
            {
                m_Value = value;
                m_Target = target;

                // TODO: Compute a reasonable duration, this is stolen from ArchProtection
                double time = caster.Skills[SkillName.Magery].Value * 1.2;
                if ( time > 144 )
                    time = 144;
                Delay = TimeSpan.FromSeconds( time );
                Priority = TimerPriority.OneSecond;
            }

            protected override void OnTick()
            {
                m_Target.EndAction( typeof( DecayingRaySpell ) );
                m_Target.VirtualArmorMod += m_Value;
            }
        }

        private class InternalTarget : Target
        {
            private DecayingRaySpell m_Owner;

            // TODO: What is thie Core.ML stuff, is it needed?
            public InternalTarget( DecayingRaySpell owner ) : base( Core.ML ? 10 : 12, false, TargetFlags.Harmful )
            {
                m_Owner = owner;
            }

            protected override void OnTarget( Mobile from, object o )
            {
                if ( o is Mobile )
                    m_Owner.Target( (Mobile) o );
            }

            protected override void OnTargetFinish( Mobile from )
            {
                m_Owner.FinishSequence();
            }
        }
    }
}