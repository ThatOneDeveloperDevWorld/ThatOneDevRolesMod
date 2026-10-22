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

    public override float Cooldown => 30f; 
    public override bool PauseTimerInVent => true;

    public override LoadableAsset<Sprite> Sprite => MiraAssets.ImpostorFile; 
    public override MiraKeybind? Keybind => MiraGlobalKeybinds.PrimaryAbility;

    protected override void OnClick()
    {
        if (Target == null || Target.Data == null || Target.Data.IsDead) return;

        PlayerControl sheriff = PlayerControl.LocalPlayer;

        // Check if target is an impostor via Role.IsImpostor on NetworkedPlayerInfo
        bool isTargetImpostor = Target.Data.Role != null && Target.Data.Role.IsImpostor;

        if (isTargetImpostor)
        {
            // Target is Impostor: Eliminate the target
            sheriff.MurderPlayer(Target, MurderResultFlags.Succeeded);
        }
        else
        {
            // Target is Crewmate: Misfire and eliminate the Sheriff
            sheriff.MurderPlayer(sheriff, MurderResultFlags.Succeeded);
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