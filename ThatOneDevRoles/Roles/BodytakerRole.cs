using HarmonyLib;
using MiraAPI.Roles;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace ThatOneDevRoles.Roles;

public class BodytakerRole : ImpostorRole, ICustomRole
{
    public string IdPart => "Bodytaker";
    public string IdPrefix => "ThatOneDevRoles.Role.Impostor";

    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        Icon = ThatOneDevRolesAssets.TODRIMPIcon,
        IconTmp = TmpSpriteUtils.CreateSpriteAsset(
            ThatOneDevRolesAssets.TODRIMPicon.LoadAsset() ?? MiraAssets.ImpostorFile.LoadAsset(),
            "ThatOneDevRoles.Role.Impostor.Bodytaker"
        ),
        OptionsScreenshot = ThatOneDevRolesAssets.BannerImp,
        MaxRoleCount = 15,
    };
}