using System;
using System.Collections;
using Server.Network;
using Server.Items;
using Server.Targeting;
using Server.Mobiles;

namespace Server.Spells.Necromancy
{
    public class SacrificeSpell : NecromancerSpell, IMobileTargeted
    {
        private static SpellInfo m_Info = new SpellInfo(
                "Sacrifice", "Animus Ex Corporis Resolveretur"
                );

        public override TimeSpan CastDelayBase { get { return TimeSpan.FromSeconds( 0 ); } }

        public override double RequiredSkill{ get{ return 100.0; } }
        public override int RequiredMana{ get{ return 60; } }

        public SacrificeSpell( Mobile caster, Item scroll ) : base( caster, scroll, m_Info )
        {
        }

        public override void OnCast()
        {
            Caster.Target = new MobileTarget( this, 10, TargetFlags.Harmful );
        }

        public void OnTargetFinished( Mobile m ) {
            FinishSequence();
        }

        public void OnTarget( Mobile from, Mobile m )
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

            if ( ! m.BeginAction( typeof( SacrificeSpell ) ) ) {
                goto Return;
            }

            BaseCreature c = m as BaseCreature;

            if ( c == null ) {
                Caster.SendMessage("You cannot sacrifice that.");
                goto Return;
            }
            if ( c.ControlMaster != Caster ) {
                Caster.SendMessage("You cannot sacrifice a creature that does not obey you.");
                goto Return;
            }

            if ( c.Summoned ) {
                Caster.SendMessage("There is not enough life there to sacrifice.");
            }


            Caster.BoltEffect( 0 );
            Caster.PlaySound( 0x207 );

            double dmg = c.Hits * SpellHelper.GetEffectiveness(Caster);
            dmg = Utility.RandomGaussian(dmg, dmg/4);

            foreach ( Mobile target in Caster.Map.GetMobilesInRange(Caster.Location, 4) ) {
                if ( ! Caster.CanSee( target ) ) continue;

                Caster.DoHarmful( target );
                target.Damage((int)dmg, Caster, DamageType.Necro);
            }

        Return:
            FinishSequence();
        }
    }
}
