using System;
using Server.Mobiles;
using Server.Network;
using Server.Mobiles;
using Server.Items;

namespace Server.Items
{
    [FlipableAttribute( 0x143E, 0x143F )]
    public class Halberd : BasePoleArm
    {
	public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.WhirlwindAttack; } }
	public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ConcussionBlow; } }
	public override double GetBaseDamage( Mobile attacker ){
	    if( attacker is BaseCreature ){
		return base.GetBaseDamage( attacker );
	    }
	    
	    int damage = Utility.Dice( 2, 23, 3 );

	    if ( DamageLevel != WeaponDamageLevel.Regular ){
                damage += (2 * (int)DamageLevel) - 1;
	    }

	    return damage;
	}
	
	public override int AosStrengthReq{ get{ return 95; } }
	public override int AosMinDamage{ get{ return 18; } }
	public override int AosMaxDamage{ get{ return 19; } }
	public override int AosSpeed{ get{ return 25; } }
	public override float MlSpeed{ get{ return 4.25f; } }

	public override int OldStrengthReq{ get{ return 45; } }
	public override int OldMinDamage{ get{ return 5; } }
	public override int OldMaxDamage{ get{ return 49; } }
	public override int OldSpeed{ get{ return 25; } }

	public override int InitMinHits{ get{ return 31; } }
	public override int InitMaxHits{ get{ return 80; } }

	[Constructable]
	public Halberd() : base( 0x143E )
	{
	    Weight = 16.0;
	}

	public Halberd( Serial serial ) : base( serial )
	{
	}

	public override void Serialize( GenericWriter writer )
	{
	    base.Serialize( writer );

	    writer.Write( (int) 0 ); // version
	}

	public override void Deserialize( GenericReader reader )
	{
	    base.Deserialize( reader );

	    int version = reader.ReadInt();
	}
    }
}
