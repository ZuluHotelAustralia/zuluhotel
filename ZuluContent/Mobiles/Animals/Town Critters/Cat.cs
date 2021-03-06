namespace Server.Mobiles
{
    [CorpseName( "a cat corpse" )]
	[TypeAlias( "Server.Mobiles.Housecat" )]
	public class Cat : BaseCreature
	{

		[Constructible]
public Cat() : base( AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			Name = "a cat";
			Body = 0xC9;
			Hue = Utility.RandomAnimalHue();
			BaseSoundID = 0x69;

			SetStr( 9 );
			SetDex( 35 );
			SetInt( 5 );

			SetHits( 6 );
			SetMana( 0 );

			SetDamage( 1 );

			SetSkill( SkillName.MagicResist, 5.0 );
			SetSkill( SkillName.Tactics, 4.0 );
			SetSkill( SkillName.Wrestling, 5.0 );

			Fame = 0;
			Karma = 150;

			VirtualArmor = 8;

			Tamable = true;
			ControlSlots = 1;
			MinTameSkill = -0.9;
		}

		public override int Meat{ get{ return 1; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat | FoodType.Fish; } }

		[Constructible]
public Cat(Serial serial) : base(serial)
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

			int version = reader.ReadInt();
		}
	}
}
