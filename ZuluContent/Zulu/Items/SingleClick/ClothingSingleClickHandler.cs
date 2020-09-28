using Server;
using Server.Items;
using ZuluContent.Zulu.Engines.Magic;

namespace ZuluContent.Zulu.Items.SingleClick
{
    public static partial class SingleClickHandler
    {
        public static void HandleSingleClick(BaseClothing item, Mobile m)
        {
            HandleSingleClick((IMagicItem)item, m);
        }
    }
}