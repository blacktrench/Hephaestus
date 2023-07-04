using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis.Settings;

namespace Hephaestus
{
    // A class to store the settings for each race and gender
    public class BaseSettings
    {
        [SynthesisSettingName("The keyword your crafting furniture uses")]
        public IFormLinkGetter<IKeywordGetter> BenchKeyword { get; set; } =
            FormLinkGetter<IKeywordGetter>.Null;

        [SynthesisSettingName("The name of the crafting furniture")]
        public string objBenchName { get; set; } = String.Empty;

        [SynthesisSettingName("The name of the process")]
        public string processName { get; set; } = String.Empty;

        [SynthesisSettingName("The name of the schematic item")]
        public string schematicTypeName { get; set; } = String.Empty;
    }

    public class Settings
    {
        // A dictionary to store the settings for each race and gender
        // The key is a string of the form "Race", e.g. "NordRace"
        // the "Default" entry is not an actual race but is used as the default if ScaleEverything is toggled on
        // The value is an instance of BaseSettings
        [SynthesisSettingName("Crafting furniture settings")]
        public List<BaseSettings> BenchSettings { get; set; } =
            new()
            {
                new BaseSettings()
                {
                    BenchKeyword = Skyrim.Keyword.CraftingSmithingForge,
                    objBenchName = "Forge",
                    processName = "shape",
                    schematicTypeName = "Schematic"
                },
                new BaseSettings()
                {
                    BenchKeyword = Skyrim.Keyword.CraftingTanningRack,
                    objBenchName = "Tanning Rack",
                    processName = "stitch",
                    schematicTypeName = "Pattern"
                },
                new BaseSettings()
                {
                    BenchKeyword = Skyrim.Keyword.CraftingCookpot,
                    objBenchName = "Cooking Pot",
                    processName = "cook",
                    schematicTypeName = "Recipe"
                }
            };

        [SynthesisSettingName("Drop chance % (out of 100)")]
        [SynthesisDescription("Goes from 0 to 100, it affects how likely schematics are to drop")]
        [SynthesisTooltip("Goes from 0 to 100, it affects how likely schematics are to drop")]
        public int DropChance { get; set; } = 1;

        [SynthesisSettingName("Tempering requires the schematic too")]
        [SynthesisDescription("Makes it so you need the schematic to temper items too")]
        [SynthesisTooltip("Makes it so you need the schematic to temper items too")]
        public bool TemperReqSchematic { get; set; } = true;

        [SynthesisSettingName("Use smelter to break down items")]
        [SynthesisTooltip("Otherwise you'll get exp for every item breakdown")]
        public bool useSmelter { get; set; } = true;

        [SynthesisSettingName("Blacklist items")]
        public List<IFormLinkGetter<IItemGetter>> itemBlacklist { get; set; } = new();

        [SynthesisSettingName("Add names to pool of crafters")]
        [SynthesisDescription(
            "Any name added here is added to the pool of names that get used when generating the looted schematics"
        )]
        [SynthesisTooltip(
            "Any name added here is added to the pool of names that get used when generating the looted schematics"
        )]
        public List<String> LovedOnesName { get; set; } = new();

        [SynthesisSettingName("(Debug) Show patched item info")]
        public bool ShowDebugLogs { get; set; } = false;
    }
}
