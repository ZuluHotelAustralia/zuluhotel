using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Harvest
{
        public class MiningResources
        {
                public static HarvestResource[] OreResources = new HarvestResource[]
                {
                        new HarvestResource( 0.00, 0.00, 100.00, 1007072, typeof( IronOre ), typeof( Granite ) ),
                        new HarvestResource( 1.00, 1.00, 101.00, 1007072, typeof( GoldOre ), typeof( Granite ) ),
                        new HarvestResource( 5.00, 5.00, 105.00, 1007072, typeof( SpikeOre ), typeof( Granite ) ),
                        new HarvestResource( 10.00, 10.00, 110.00, 1007072, typeof( FruityOre ), typeof( Granite ) ),
                        new HarvestResource( 15.00, 15.00, 115.00, 1007072, typeof( BronzeOre ), typeof( Granite ) ),
                        new HarvestResource( 20.00, 20.00, 120.00, 1007072, typeof( IceRockOre ), typeof( Granite ) ),
                        new HarvestResource( 25.00, 25.00, 125.00, 1007072, typeof( BlackDwarfOre ), typeof( Granite ) ),
                        new HarvestResource( 30.00, 30.00, 130.00, 1007072, typeof( DullCopperOre ), typeof( Granite ) ),
                        new HarvestResource( 35.00, 35.00, 135.00, 1007072, typeof( PlatinumOre ), typeof( Granite ) ),
                        new HarvestResource( 40.00, 40.00, 140.00, 1007072, typeof( SilverRockOre ), typeof( Granite ) ),
                        new HarvestResource( 45.00, 45.00, 145.00, 1007072, typeof( DarkPaganOre ), typeof( Granite ) ),
                        new HarvestResource( 50.00, 50.00, 150.00, 1007072, typeof( CopperOre ), typeof( Granite ) ),
                        new HarvestResource( 55.00, 55.00, 150.00, 1007072, typeof( MysticOre ), typeof( Granite ) ),
                        new HarvestResource( 60.00, 60.00, 150.00, 1007072, typeof( SpectralOre ), typeof( Granite ) ),
                        new HarvestResource( 65.00, 65.00, 150.00, 1007072, typeof( OldBritainOre ), typeof( Granite ) ),
                        new HarvestResource( 70.00, 70.00, 150.00, 1007072, typeof( OnyxOre ), typeof( Granite ) ),
                        new HarvestResource( 75.00, 75.00, 150.00, 1007072, typeof( RedElvenOre ), typeof( Granite ) ),
                        new HarvestResource( 80.00, 80.00, 150.00, 1007072, typeof( UndeadOre ), typeof( Granite ) ),
                        new HarvestResource( 85.00, 85.00, 150.00, 1007072, typeof( PyriteOre ), typeof( Granite ) ),
                        new HarvestResource( 90.00, 90.00, 150.00, 1007072, typeof( VirginityOre ), typeof( Granite ) ),
                        new HarvestResource( 95.00, 95.00, 150.00, 1007072, typeof( MalachiteOre ), typeof( Granite ) ),
                        new HarvestResource( 97.00, 97.00, 150.00, 1007072, typeof( LavarockOre ), typeof( Granite ) ),
                        new HarvestResource( 98.00, 98.00, 150.00, 1007072, typeof( AzuriteOre ), typeof( Granite ) ),
                        new HarvestResource( 100.00, 100.00, 150.00, 1007072, typeof( DripstoneOre ), typeof( Granite ) ),
                        new HarvestResource( 104.00, 104.00, 150.00, 1007072, typeof( ExecutorOre ), typeof( Granite ) ),
                        new HarvestResource( 108.00, 108.00, 150.00, 1007072, typeof( PeachblueOre ), typeof( Granite ) ),
                        new HarvestResource( 112.00, 112.00, 150.00, 1007072, typeof( DestructionOre ), typeof( Granite ) ),
                        new HarvestResource( 116.00, 116.00, 150.00, 1007072, typeof( AnraOre ), typeof( Granite ) ),
                        new HarvestResource( 119.00, 119.00, 150.00, 1007072, typeof( CrystalOre ), typeof( Granite ) ),
                        new HarvestResource( 122.00, 122.00, 150.00, 1007072, typeof( DoomOre ), typeof( Granite ) ),
                        new HarvestResource( 125.00, 125.00, 150.00, 1007072, typeof( GoddessOre ), typeof( Granite ) ),
                        new HarvestResource( 129.00, 129.00, 150.00, 1007072, typeof( NewZuluOre ), typeof( Granite ) ),
                        new HarvestResource( 130.00, 130.00, 150.00, 1007072, typeof( DarkSableRubyOre ), typeof( Granite ) ),
                        new HarvestResource( 130.00, 130.00, 150.00, 1007072, typeof( EbonTwilightSapphireOre ), typeof( Granite ) ),
                        new HarvestResource( 140.00, 140.00, 150.00, 1007072, typeof( RadiantNimbusDiamondOre ), typeof( Granite ) ),
                };

                public static HarvestVein[] OreVeins = new HarvestVein[]
                {                
                        new HarvestVein( 2.86, 0.00, OreResources[0], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[1], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[2], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[3], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[4], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[5], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[6], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[7], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[8], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[9], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[10], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[11], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[12], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[13], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[14], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[15], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[16], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[17], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[18], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[19], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[20], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[21], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[22], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[23], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[24], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[25], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[26], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[27], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[28], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[29], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[30], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[31], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[32], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[33], OreResources[0] ),                
                        new HarvestVein( 2.86, 0.00, OreResources[34], OreResources[0] ),
                };
        }
};