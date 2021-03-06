namespace Server.Mobiles
{
    public class RangerGuildmaster : BaseGuildmaster
	{
		public override NpcGuild NpcGuild{ get{ return NpcGuild.RangersGuild; } }


		[Constructible]
public RangerGuildmaster() : base( "ranger" )
		{
			SetSkill( SkillName.AnimalLore, 64.0, 100.0 );
			SetSkill( SkillName.Camping, 75.0, 98.0 );
			SetSkill( SkillName.Hiding, 75.0, 98.0 );
			SetSkill( SkillName.MagicResist, 75.0, 98.0 );
			SetSkill( SkillName.Tactics, 65.0, 88.0 );
			SetSkill( SkillName.Archery, 90.0, 100.0 );
			SetSkill( SkillName.Tracking, 90.0, 100.0 );
			SetSkill( SkillName.Stealth, 60.0, 83.0 );
			SetSkill( SkillName.Fencing, 36.0, 68.0 );
			SetSkill( SkillName.Herding, 36.0, 68.0 );
			SetSkill( SkillName.Swords, 45.0, 68.0 );
		}

		[Constructible]
public RangerGuildmaster( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( IGenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( IGenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
