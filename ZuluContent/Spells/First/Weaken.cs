using System;
using System.Threading.Tasks;
using Server.Targeting;
using ZuluContent.Zulu.Engines.Magic.Enchantments.Buffs;

namespace Server.Spells.First
{
    public class WeakenSpell : MagerySpell, ITargetableAsyncSpell<Mobile>
    {
        public WeakenSpell(Mobile caster, Item spellItem = null) : base(caster, spellItem) { }

        public async Task OnTargetAsync(ITargetResponse<Mobile> response)
        {
            if (!response.HasValue)
                return;
            
            var target = response.Target;
            
            if (!Caster.CanBuff(target, true, BuffIcon.Bless, BuffIcon.Strength, BuffIcon.Resilience, BuffIcon.Weaken))
                return;
            
            target.TryAddBuff(new StatBuff(StatType.Str)
            {
                Value = SpellHelper.GetModAmount(Caster, target, StatType.Str) * -1,
                Duration = SpellHelper.GetDuration(Caster, target),
            });
            
            SpellHelper.Turn(Caster, target);

            target.Spell?.OnCasterHurt();
            target.Paralyzed = false;

            target.FixedParticles(0x3779, 10, 15, 5009, EffectLayer.Waist);
            target.PlaySound(0x1E6);
        }
    }
}