using System;
using System.Threading.Tasks;
using Server.Targeting;
using ZuluContent.Zulu.Engines.Magic.Enchantments.Buffs;

#pragma warning disable 1998

namespace Server.Spells.First
{
    public class FeeblemindSpell : MagerySpell, ITargetableAsyncSpell<Mobile>
    {
        public FeeblemindSpell(Mobile caster, Item spellItem = null) : base(caster, spellItem)
        {
        }

        public async Task OnTargetAsync(ITargetResponse<Mobile> response)
        {
            if (!response.HasValue)
                return;
            
            var target = response.Target;

            SpellHelper.Turn(Caster, target);
            
            if (!Caster.CanBuff(target, true,  BuffIcon.Bless, BuffIcon.Cunning, BuffIcon.Resilience, BuffIcon.FeebleMind))
                return;
            
            target.TryAddBuff(new StatBuff(StatType.Int)
            {
                Value = SpellHelper.GetModAmount(Caster, target, StatType.Int) * -1,
                Duration = SpellHelper.GetDuration(Caster, target),
            });

            target.Spell?.OnCasterHurt();
            target.Paralyzed = false;

            target.FixedParticles(0x3779, 10, 15, 5004, EffectLayer.Head);
            target.PlaySound(0x1E4);
        }
    }
}