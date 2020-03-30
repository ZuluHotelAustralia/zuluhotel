using System;
using Server;
using Server.Items;

namespace Server.Spells.Necromancy
{
    public abstract class NecromancerSpell : Spell
    {
	public abstract double RequiredSkill{ get; }
	public abstract int RequiredMana{ get; }
	    
	public override SpellCircle Circle { get { return SpellCircle.Necro; } }
	
	public override TimeSpan GetCastDelay(){
	    return TimeSpan.FromSeconds( 2.0 );
	}

	public override TimeSpan CastDelayBase {
	    get { return TimeSpan.FromSeconds( 5 ); }
	}	       
	
	public override SkillName CastSkill{ get{ return SkillName.Magery; } }
	public override SkillName DamageSkill{ get{ return SkillName.SpiritSpeak; } }

	//public override int CastDelayBase{ get{ return base.CastDelayBase; } } // Reference, 3

	public override bool ClearHandsOnCast{ get{ return false; } }

	public override double CastDelayFastScalar{ get{ return (Core.SE? base.CastDelayFastScalar : 0); } } // Necromancer spells are not affected by fast cast items, though they are by fast cast recovery

	public NecromancerSpell( Mobile caster, Item scroll, SpellInfo info ) : base( caster, scroll, info )
	{
	    m_DamageType = DamageType.Necro;
	}

	public override int ComputeKarmaAward()
	{
	    //TODO: Verify this formula being that Necro spells don't HAVE a circle.
	    //int karma = -(70 + (10 * (int)Circle));
	    int karma = -(40 + (int)(10 * (CastDelayBase.TotalSeconds / CastDelaySecondsPerTick)));

	    if ( Core.ML ) // Pub 36: "Added a new property called Increased Karma Loss which grants higher karma loss for casting necromancy spells."
		karma += AOS.Scale( karma, AosAttributes.GetValue( Caster, AosAttribute.IncreasedKarmaLoss ) );

	    return karma;
	}

	public override void GetCastSkills( out double min, out double max )
	{
	    min = RequiredSkill;
	    max = Scroll != null ? min : RequiredSkill + 40.0;

	    if( max > 150 ){
		max = 150;
	    }
	}

	public override bool ConsumeReagents()
	{
	    if( base.ConsumeReagents() )
		return true;

	    if( ArcaneGem.ConsumeCharges( Caster, 1 ) )
		return true;

	    return false;
	}

	public override int GetMana()
	{
	    return RequiredMana;
	}
    }
}
