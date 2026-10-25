using ThatOneDevRoles.Roles;
using MiraAPI.GameOptions;
using MiraAPI.Utilities;
using MiraAPI.Utilities.Assets;

namespace ThatOneDevRoles.Options.Roles;

public class DoppelgangerRoleSettings : AbstractOptionGroup<DoppelgangerRole>
{
    public override OptionNotifConfiguration Configuration => new(
        Palette.ImpostorRed,
        TmpSpriteUtils.CreateSpriteAsset(
            ThatOneDevRolesAssets.DoppelgangerIcon.LoadAsset() ?? MiraAssets.ImpostorFile.LoadAsset(),
            "ThatOneDevRoles.Role.Impostor.DoppelgangerRole"));

    public override string GroupName => "ThatOneDevRoles.Role.Impostor.Doppelganger";
}