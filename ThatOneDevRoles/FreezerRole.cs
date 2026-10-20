using MiraAPI.Roles;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace ThatOneDevRoles.Roles;

public class FreezerRole : ImpostorRole, ICustomRole
{
    public string IdPart => "Freezer";
    public string IdPrefix => "ThatOneDevRoles.Role.Impostor";
    public Color RoleColor => Palette.Blue;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        Icon = MiraAssets.ImpostorFile,
        IconTmp = TmpSpriteUtils.CreateSpriteAsset(MiraAssets.ImpostorFile.LoadAsset(), "ThatOneDevRoles.Role.Impostor.Freezer"),
        OptionsScreenshot = ExampleAssets.Banner,
        MaxRoleCount = 2,
    };
}
