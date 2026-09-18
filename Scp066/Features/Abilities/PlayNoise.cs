using System.Collections.Generic;
using System.Linq;
using LabApi.Features.Wrappers;
using MEC;
using PlayerRoles;
using PlayerStatsSystem;
using RoleAPI.API.Abilities;
using UnityEngine;

namespace Scp066.Features.Abilities;

public class PlayNoise : AbilityBase
{
    public override string Name => "\ud83c\udfba Noise";

    public override string Description => "Plays Beethoven, which kills players";

    public override KeyCode DefaultKey => KeyCode.F;

    public override float Cooldown => 40f;

    public override string SoundResource => "Audio.Beethoven.ogg";

    protected override void OnExecute(AbilityExecutionContext context)
    {
        float damage = Scp066.Singleton.Config.Damage;
        float maxDistance = Scp066.Singleton.Config.MaxDistance;

        if (maxDistance <= 0 || damage <= 0)
        {
            context.Deny("Invalid distance or damage configuration.");
            return;
        }

        context.LocksDuringExecution = true;
        Timing.RunCoroutine(DamageLoop(context, maxDistance, damage, Scp066.Singleton.Config.CustomDeathText));
    }

    private static IEnumerator<float> DamageLoop(AbilityExecutionContext context, float maxDistance, float damage, string damageText)
    {
        // Brief wait for audio to start
        yield return Timing.WaitForSeconds(0.2f);

        float elapsed = 0f;
        while (elapsed < 25f)
        {
            foreach (Player p in Player.ReadyList.Where(p => Vector3.Distance(context.Player.Position, p.Position) <= maxDistance && !p.IsSCP && p.IsAlive && p.Team != Team.OtherAlive))
                p.Damage(new CustomReasonDamageHandler(damageText, damage));

            yield return Timing.WaitForSeconds(1f);
            elapsed += 1f;
        }
    }
}