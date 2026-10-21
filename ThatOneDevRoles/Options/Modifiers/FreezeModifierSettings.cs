using ThatOneDevRoles.Modifiers.Freezer;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;

namespace ThatOneDevRoles.Options.Modifiers;

public class FreezeModifierSettings : AbstractOptionGroup<FreezeModifier>
{
    public override string GroupName => "options.freezeModifierSettings";

    [ModdedToggleOption("options.freezeModifierSettings.useColor")]
    public bool UseColor { get; set; } = true;
}
