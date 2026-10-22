using ThatOneDevRoles.Roles;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;

namespace ThatOneDevRoles.Options.Roles;

public class SheriffRoleSettings : AbstractOptionGroup<SheriffRole>
{
    public override OptionNotifConfiguration Configuration => new(
        Palette.CrewmateBlue,
        TmpSpriteUtils.CreateSpriteAsset(
            MiraAssets.CrewmateFile.LoadAsset(),
            "ThatOneDevRoles.Role.Crewmate.SheriffRole"));

    public override string GroupName => "ThatOneDevRoles.Role.Crewmate.Sheriff";

    [ModdedNumberOption("ThatOneDevRoles.Role.Crewmate.Sheriff.Settings.ShootCooldown", 10, 60, 2.5f, MiraNumberSuffixes.Seconds)]
    public float ShootCooldown { get; set; } = 30;

    [ModdedNumberOption("ThatOneDevRoles.Role.Crewmate.Sheriff.Settings.MaxShots", 1, 15, 1)]
    public float MaxShots { get; set; } = 3;

    [ModdedToggleOption("ThatOneDevRoles.Role.Crewmate.Sheriff.Settings.MisfireKillsSheriff")]
    public bool MisfireKillsSheriff { get; set; } = true;
}