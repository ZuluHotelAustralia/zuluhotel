using System;
using System.Collections;
using System.Threading.Tasks;
using Server;
using Server.Engines.Magic;
using Server.Network;
using Server.Items;
using Server.Targeting;
using Server.Spells;

namespace Scripts.Zulu.Spells.Earth
{
    public class CallLightningSpell : EarthSpell, ITargetableAsyncSpell<Mobile>
    {
        public CallLightningSpell(Mobile caster, Item spellItem) : base(caster, spellItem) { }

        public async Task OnTargetAsync(ITargetResponse<Mobile> response)
        {
            if (!response.HasValue)
                return;
            
            var target = response.Target;
            
            SpellHelper.Turn(Caster, target);
            
            var damage = SpellHelper.CalcSpellDamage(Caster, target, this);
            target.BoltEffect(0);
            await Timer.Pause(100);
            target.BoltEffect(0);
            
            SpellHelper.Damage(damage, target, Caster, this);
        }
    }
}