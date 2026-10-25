using MiraAPI.Roles;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace ThatOneDevRoles.Roles;

public class DoppelgangerRole : ImpostorRole, ICustomRole
{
    public string IdPart => "Doppelganger";
    public string IdPrefix => "ThatOneDevRoles.Role.Impostor";

    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        Icon = ThatOneDevRolesAssets.DoppelgangerIcon,
        IconTmp = TmpSpriteUtils.CreateSpriteAsset(
            ThatOneDevRolesAssets.DoppelgangerIcon.LoadAsset() ?? MiraAssets.ImpostorFile.LoadAsset(),
            "ThatOneDevRoles.Role.Impostor.Doppelganger"
        ),
        OptionsScreenshot = ThatOneDevRolesAssets.Banner,
        MaxRoleCount = 15,
    };

    public override void OnKill(PlayerControl killer, PlayerControl target)
    {
        base.OnKill(killer, target);

        if (killer == null || target == null) return;

        var killerData = killer.Data;
        var targetData = target.Data;

        if (killerData == null || targetData == null) return;

        var savedKillerDefaultOutfit = killerData.DefaultOutfit;
        
        killer.SetOutfit(targetData.DefaultOutfit);

        target.SetOutfit(savedKillerDefaultOutfit);
    }
}