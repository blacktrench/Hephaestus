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
        public string objBenchName { get; set; } = string.Empty;

        [SynthesisSettingName("The name of the process")]
        public string processName { get; set; } = string.Empty;

        [SynthesisSettingName("The name of the schematic item")]
        public string schematicTypeName { get; set; } = string.Empty;

        [SynthesisSettingName("Do not modify any recipes that use this keyword")]
        public bool ignore { get; set; } = false;
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
                    schematicTypeName = "Pattern",
                    ignore = true
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

        [SynthesisSettingName("Add schematics to merchants?")]
        public bool distributeVendors { get; set; } = true;

        [SynthesisSettingName("Add schematics to blacksmiths?")]
        public bool distributeBlacksmiths { get; set; } = true;

        [SynthesisSettingName(
            "Add schematics to special loot (special chests, boss chests, etc.)?"
        )]
        public bool distributeSpecial { get; set; } = true;

        [SynthesisSettingName("Add schematics to some general loot?")]
        public bool distributeGeneralLoot { get; set; } = false;

        [SynthesisSettingName("Add custom lists to distribute schematics to")]
        [SynthesisTooltip(
            "Keep in mind that any leveled list that is used as an outfit by NPCs may cause issues with some instances of said NPCs being naked."
        )]
        public List<IFormLinkGetter<ILeveledItemGetter>> LVLIWhitelist { get; set; } = new();

        [SynthesisSettingName("Add names to pool of crafters")]
        [SynthesisDescription(
            "Any name added here is added to the pool of names that get used when generating the looted schematics"
        )]
        [SynthesisTooltip(
            "Any name added here is added to the pool of names that get used when generating the looted schematics"
        )]
        public List<string> LovedOnesName { get; set; } = new();

        [SynthesisSettingName("Weight of schematic fragments")]
        public float fragmentWeight { get; set; } = 0.1f;

        [SynthesisSettingName("Weight of schematic books.")]
        public float schematicWeight { get; set; } = 0.25f;

        [SynthesisSettingName("(Debug) Show patched item info")]
        public bool ShowDebugLogs { get; set; } = false;
    }
}
