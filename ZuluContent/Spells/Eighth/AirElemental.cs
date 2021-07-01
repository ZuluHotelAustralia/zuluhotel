using System;
using System.Threading.Tasks;
using Server.Mobiles;
using ZuluContent.Zulu.Engines.Magic;

namespace Server.Spells.Eighth
{
    public class AirElementalSpell : MagerySpell, IAsyncSpell
    {
        public AirElementalSpell(Mobile caster, Item spellItem = null) : base(caster, spellItem) { }

        public async Task CastAsync()
        {
            SpellHelper.Summon("AirElemental", Caster, 0x217);
        }
    }
}