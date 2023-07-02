using Mutagen.Bethesda.Synthesis.Settings;

namespace Hephaestus
{
    public class Settings
    {
        [SynthesisSettingName("Drop chance")]
        [SynthesisDescription("Goes from 0 to 100, it affects how likely schematics are to drop")]
        [SynthesisTooltip("Goes from 0 to 100, it affects how likely schematics are to drop")]
        public int DropChance { get; set; } = 1;

        [SynthesisSettingName("(Debug) Show patched item info")]
        public bool ShowDebugLogs { get; set; } = true;
    }
}
