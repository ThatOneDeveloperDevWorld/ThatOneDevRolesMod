using MiraAPI.Utilities.Assets;

namespace ThatOneDevRoles;

public static class ThatOneDevRolesAssets
{
    public static LoadableResourceAsset FreezeButton { get; } = new("ThatOneDevRoles.Resources.ExampleButton.png");
    public static LoadableResourceAsset CallMeetingButton { get; } = new("ThatOneDevRoles.Resources.CallMeeting.png");

    // Credit to EpicHorrors for the teleport button asset.
    public static LoadableResourceAsset TeleportButton { get; } = new("ThatOneDevRoles.Resources.TeleportButton.png");
    public static LoadableResourceAsset SharpshootButton { get; } = new("ThatOneDevRoles.Resources.SharpshootButton.png");
    public static LoadableResourceAsset Banner { get; } = new("ThatOneDevRoles.Resources.FortniteBanner.jpeg");
}
