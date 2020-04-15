using System;
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Items
{
    [FlipableAttribute( 0x13B8, 0x13B7 )]
    public class ThinLongsword : BaseSword
    {
	public override int AosStrengthReq{ get{ return 35; } }
	public override int AosMinDamage{ get{ return 15; } }
	public override int AosMaxDamage{ get{ return 16; } }
	public override int AosSpeed{ get{ return 30; } }
	public override float MlSpeed{ get{ return 3.50f; } }

	public override int OldStrengthReq{ get{ return 25; } }
	public override int OldMinDamage{ get{ return 5; } }
	public override int OldMaxDamage{ get{ return 33; } }
	public override int OldSpeed{ get{ return 35; } }

	public override int DefHitSound{ get{ return 0x237; } }
	public override int DefMissSound{ get{ return 0x23A; } }

	public override int InitMinHits{ get{ return 31; } }
	public override int InitMaxHits{ get{ return 110; } }

	public override double GetBaseDamage( Mobile attacker ){
	    if( attacker is BaseCreature ){
		return base.GetBaseDamage( attacker );
	    }
	    
	    int damage = Utility.Dice( 2, 15, 3 );

	    if ( DamageLevel != WeaponDamageLevel.Regular ){
                damage += (2 * (int)DamageLevel) - 1;
	    }

	    return damage;
	}

	[Constructable]
	public ThinLongsword() : base( 0x13B8 )
	{
	    Weight = 1.0;
	}

	public ThinLongsword( Serial serial ) : base( serial )
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
