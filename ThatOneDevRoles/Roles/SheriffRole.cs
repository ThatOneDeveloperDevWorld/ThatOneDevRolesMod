using MiraAPI.Roles;
using MiraAPI.Utilities.Assets;
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
        Icon = ThatOneDevRolesAssets.SheriffIcon,
        IconTmp = TmpSpriteUtils.CreateSpriteAsset(
            ThatOneDevRolesAssets.SheriffIcon.LoadAsset(), 
            "ThatOneDevRoles.Role.Crewmate.Sheriff"
        ),
        OptionsScreenshot = ThatOneDevRolesAssets.BannerCrew,
        MaxRoleCount = 15,
    };
}