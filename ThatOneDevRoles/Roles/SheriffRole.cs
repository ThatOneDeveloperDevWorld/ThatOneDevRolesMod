using MiraAPI.Roles;
using MiraAPI.Utilities.Assets;
using ThatOneDevRoles.Buttons.Sheriff;
using UnityEngine;

namespace ThatOneDevRoles.Roles;

public class SheriffRole : CrewmateRole, ICustomRole
{
    public string IdPart => "Sheriff";
    public string IdPrefix => "ThatOneDevRoles.Role.Crewmate";
    
    public Color RoleColor => Palette.CrewmateBlue; 
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        Icon = MiraAssets.CrewmateFile,
        IconTmp = TmpSpriteUtils.CreateSpriteAsset(MiraAssets.CrewmateFile.LoadAsset(), "ThatOneDevRoles.Role.Crewmate.Sheriff"),
        OptionsScreenshot = ThatOneDevRolesAssets.Banner,
        MaxRoleCount = 1,
        CustomButtons = new[] { typeof(ShootButton) }
    };
}