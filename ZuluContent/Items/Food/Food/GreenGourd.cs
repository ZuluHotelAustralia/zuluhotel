namespace Server.Items
{
    [Flipable( 0xC66, 0xC67 )]
    public class GreenGourd : Food
    {

        [Constructible]
public GreenGourd() : this( 1 )
        {
        }


        [Constructible]
public GreenGourd( int amount ) : base( amount, 0xC66 )
        {
            Weight = 1.0;
            FillFactor = 1;
        }

        [Constructible]
public GreenGourd( Serial serial ) : base( serial )
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
