using MiraAPI.Hud.Buttons;
using MiraAPI.Roles;
using ThatOneDevRoles.Roles;
using UnityEngine;

namespace ThatOneDevRoles.Buttons.Sheriff;

public class ShootButton : TargetCustomButton<SheriffRole>
{
    public override string Text => "Shoot";
    public override Sprite Sprite => MiraAssets.KillButton;
    public override float Cooldown => 30f;

    public override bool CouldUse()
    {
        return base.CouldUse() && PlayerControl.LocalPlayer != null && !PlayerControl.LocalPlayer.Data.IsDead;
    }

    public override void OnClick()
    {
        if (CurrentTarget == null) return;

        PlayerControl target = CurrentTarget;
        PlayerControl sheriff = PlayerControl.LocalPlayer;

        if (target.Data == null || target.Data.IsDead) return;

        if (target.Data.Role.IsImpostor || target.Is(ModdedRoleTeams.Impostor))
        {
            target.MurderPlayer(target);
        }
        else
        {
            sheriff.MurderPlayer(sheriff);
        }

        ResetCooldown();
    }
}