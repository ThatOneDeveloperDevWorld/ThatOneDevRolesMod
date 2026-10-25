using HarmonyLib;
using MiraAPI.Roles;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace ThatOneDevRoles.Roles;

public class DoppelgangerRole : ImpostorRole, ICustomRole
{
    public string IdPart => "Doppelganger";
    public string IdPrefix => "ThatOneDevRoles.Role.Impostor";

    public Color RoleColor => Palette.ImpostorRed;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        Icon = ThatOneDevRolesAssets.DoppelgangerIcon,
        IconTmp = TmpSpriteUtils.CreateSpriteAsset(
            ThatOneDevRolesAssets.DoppelgangerIcon.LoadAsset() ?? MiraAssets.ImpostorFile.LoadAsset(),
            "ThatOneDevRoles.Role.Impostor.Doppelganger"
        ),
        OptionsScreenshot = ThatOneDevRolesAssets.Banner,
        MaxRoleCount = 1,
    };
}

// Harmony Patch to handle the identity swap exclusively when a Doppelganger kills
[HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.MurderPlayer))]
public static class DoppelgangerKillPatch
{
    public static void Postfix(PlayerControl __instance, PlayerControl target, MurderResultFlags __result)
    {
        // 1. Only run if the murder attempt succeeded
        if (!__result.HasFlag(MurderResultFlags.Succeeded)) return;
        if (__instance == null || target == null) return;

        // 2. EXCLUSIVE CHECK: Only run if the killer is a Doppelganger
        if (__instance.Data?.Role is not DoppelgangerRole) return;

        var killerData = __instance.Data;
        var targetData = target.Data;
        if (killerData == null || targetData == null) return;

        // 3. Swap visual cosmetics
        var savedKillerOutfit = killerData.DefaultOutfit;
        var savedTargetOutfit = targetData.DefaultOutfit;

        __instance.SetOutfit(savedTargetOutfit);
        target.SetOutfit(savedKillerOutfit);
    }
}