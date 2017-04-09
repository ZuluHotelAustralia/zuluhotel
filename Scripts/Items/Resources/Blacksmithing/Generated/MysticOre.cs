// Generated File. DO NOT MODIFY BY HAND.
namespace Server.Items
{

public class MysticOre : BaseOre
{
        [Constructable]
        public MysticOre() : this( 1 )
        {
        }

        [Constructable]
        public MysticOre( int amount ) : base( CraftResource.Mystic, amount )
        {
        }

        public MysticOre( Serial serial ) : base( serial )
        {
        }

        public override string DefaultName
        {
                get
                {
                        return "Mystic ore";
                }
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

        public override BaseIngot GetIngot()
        {
                return new MysticIngot();
        }

        public override void OnSingleClick( Mobile from )
        {
                from.SendMessage("Mystic ore");
        }
}

}