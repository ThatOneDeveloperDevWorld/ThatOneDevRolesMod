using MiraAPI.Utilities.Assets;

namespace ThatOneDevRoles;

public static class ThatOneDevRolesAssets
{
    public static LoadableResourceAsset ShootButton { get; } = new("ThatOneDevRoles.Resources.SheriffIcon.png");
    public static LoadableResourceAsset SheriffIcon { get; } = new("ThatOneDevRoles.Resources.SheriffIcon.png");
    
    // Safely fallback Banner to ShootButton if Banner.png doesn't exist in your Resources folder yet
    public static LoadableResourceAsset Banner { get; } = new("ThatOneDevRoles.Resources.SheriffIcon.png");
}