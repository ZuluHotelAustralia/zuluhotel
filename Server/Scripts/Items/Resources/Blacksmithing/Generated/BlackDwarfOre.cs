// Generated File. DO NOT MODIFY BY HAND.
namespace Server.Items
{

public class BlackDwarfOre : BaseOre
{
        [Constructable]
        public BlackDwarfOre() : this( 1 )
        {
        }

        [Constructable]
        public BlackDwarfOre( int amount ) : base( CraftResource.BlackDwarf, amount )
        {
        }

        public BlackDwarfOre( Serial serial ) : base( serial )
        {
        }

        public override string DefaultName
        {
                get
                {
                        return "Black Dwarf ore";
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
                return new BlackDwarfIngot();
        }

        public override void OnSingleClick( Mobile from )
        {
                from.SendMessage("BlackDwarf ore");
        }
}

}