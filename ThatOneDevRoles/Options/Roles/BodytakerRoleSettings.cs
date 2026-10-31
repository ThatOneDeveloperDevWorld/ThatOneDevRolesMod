using ThatOneDevRoles.Roles;
using MiraAPI.GameOptions;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;

namespace ThatOneDevRoles.Options.Roles;

public class BodytakerRoleSettings : AbstractOptionGroup<BodytakerRole>
{
    public override OptionNotifConfiguration Configuration => new(
        Palette.ImpostorRed,
        TmpSpriteUtils.CreateSpriteAsset(
            ThatOneDevRolesAssets.TODRIMPicon.LoadAsset() ?? MiraAssets.ImpostorFile.LoadAsset(),
            "ThatOneDevRoles.Role.Impostor.BodytakerRole"));

    public override string GroupName => "ThatOneDevRoles.Role.Impostor.Bodytaker";
}