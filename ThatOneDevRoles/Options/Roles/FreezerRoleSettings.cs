using ThatOneDevRoles.Roles;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;

namespace ThatOneDevRoles.Options.Roles;

public class FreezerRoleSettings : AbstractOptionGroup<FreezerRole>
{
    public override OptionNotifConfiguration Configuration => new(
        Palette.Blue,
        TmpSpriteUtils.CreateSpriteAsset(
            MiraAssets.ImpostorFile.LoadAsset(),
            "ThatOneDevRoles.Role.Impostor.FreezerRole"));
    public override string GroupName => "ThatOneDevRoles.Role.Freezer";

    [ModdedNumberOption("ThatOneDevRoles.Role.Freezer.Settings.FreezeDuration", 1, 15, 1, MiraNumberSuffixes.Seconds)]
    public float FreezeDuration { get; set; } = 5;

    [ModdedNumberOption("ThatOneDevRoles.Role.Freezer.Settings.FreezeUses", 1, 5)]
    public float FreezeUses { get; set; } = 1;
}
