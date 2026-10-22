using ThatOneDevRoles.Roles;
using MiraAPI.Hud;
using MiraAPI.Keybinds;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace ThatOneDevRoles.Buttons.Sheriff;

public class ShootButton : CustomActionButton<PlayerControl>
{
    public override string Name => "button.shoot";

    // Standard 30 second cooldown or bind to a Sheriff options group setting
    public override float Cooldown => 30f; 
    public override bool PauseTimerInVent => true;

    // Uses default kill asset or swap with your custom loaded sprite asset
    public override LoadableAsset<Sprite> Sprite => MiraAssets.KillButton; 
    public override MiraKeybind? Keybind => MiraGlobalKeybinds.PrimaryAbility;

    protected override void OnClick()
    {
        if (Target == null || Target.Data == null || Target.Data.IsDead) return;

        PlayerControl sheriff = PlayerControl.LocalPlayer;

        // Check target team alignment
        if (Target.Data.Role.IsImpostor || Target.Is(ModdedRoleTeams.Impostor))
        {
            // Target is Impostor: Eliminate the target
            sheriff.RpcMurderPlayer(Target);
        }
        else
        {
            // Target is Crewmate: Misfire and eliminate Sheriff
            sheriff.RpcMurderPlayer(sheriff);
        }
    }

    public override PlayerControl? GetTarget()
    {
        return PlayerControl.LocalPlayer.GetClosestPlayer(true, Distance);
    }

    public override void SetOutline(bool active)
    {
        Target?.cosmetics.SetOutline(active, new Il2CppSystem.Nullable<Color>(Palette.CrewmateBlue));
    }

    public override bool IsTargetValid(PlayerControl? target)
    {
        return target != null && !target.Data.IsDead;
    }

    public override bool Enabled(RoleBehaviour? role)
    {
        return role is SheriffRole;
    }
}