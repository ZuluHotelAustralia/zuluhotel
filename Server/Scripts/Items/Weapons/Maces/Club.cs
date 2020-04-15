using System;
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Items
{
    [FlipableAttribute( 0x13b4, 0x13b3 )]
    public class Club : BaseBashing
    {
	public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ShadowStrike; } }
	public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Dismount; } }

	public override int AosStrengthReq{ get{ return 40; } }
	public override int AosMinDamage{ get{ return 11; } }
	public override int AosMaxDamage{ get{ return 13; } }
	public override int AosSpeed{ get{ return 44; } }
	public override float MlSpeed{ get{ return 2.50f; } }

	public override int OldStrengthReq{ get{ return 10; } }
	public override int OldMinDamage{ get{ return 8; } }
	public override int OldMaxDamage{ get{ return 24; } }
	public override int OldSpeed{ get{ return 40; } }

	public override int InitMinHits{ get{ return 31; } }
	public override int InitMaxHits{ get{ return 40; } }

	public override double GetBaseDamage( Mobile attacker ){
	    if( attacker is BaseCreature ){
		return base.GetBaseDamage( attacker );
	    }
	    
	    int damage = Utility.Dice( 4, 5, 4 );

	    if ( DamageLevel != WeaponDamageLevel.Regular ){
                damage += (2 * (int)DamageLevel) - 1;
	    }

	    return damage;
	}

	[Constructable]
	public Club() : base( 0x13B4 )
	{
	    Weight = 9.0;
	}

	public Club( Serial serial ) : base( serial )
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
