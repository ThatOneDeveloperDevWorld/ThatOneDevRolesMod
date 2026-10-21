using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using MiraAPI.PluginLoading;
using MiraAPI.Translation;
using Reactor;
using Reactor.Networking;
using Reactor.Networking.Attributes;
using MiraAPI;

namespace ThatOneDevRoles;

[BepInAutoPlugin("thatonedev.roles", "ThatOneDevRoles")]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
[BepInDependency(MiraApiPlugin.Id)]
[ReactorModFlags(ModFlags.RequireOnAllClients)]
public partial class ThatOneDevRolesPlugin : BasePlugin, IMiraPlugin
{
    public ThatOneDevRolesPlugin()
    {
        MiraLocaleManager.Register("thatonedev.roles");
    }
    public Harmony Harmony { get; } = new(Id);
    public string OptionsTitleText => "ThatOneDevRoles\nCool Mod By An Idiot";
    public string CustomOptionMenuNameTwo => "ThatOneDevRoles Options";
    public ConfigFile GetConfigFile() => Config;
    public override void Load()
    {
        ExampleEventHandlers.Initialize();
        Harmony.PatchAll();
    }
}
