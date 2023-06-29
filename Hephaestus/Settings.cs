using Mutagen.Bethesda.Synthesis.Settings;

namespace Hephaestus
{
    // A class to store the settings for each race and gender
    public class BaseSettings
    {
        
        [SynthesisSettingName("Minimum Male Height")]
        public double MinMaleHeightScale { get; set; } = 0.8;

        [SynthesisSettingName("Maximum Male Height")]
        public double MaxMaleHeightScale { get; set; } = 1.2;
        
        [SynthesisSettingName("Minimum Female Height")]
        public double MinFemaleHeightScale { get; set; } = 0.775;

        [SynthesisSettingName("Maximum Female Height")]
        public double MaxFemaleHeightScale { get; set; } = 1.175;
    }
    public class Settings
    {
        [SynthesisSettingName("Seed")]
        [SynthesisDescription("The seed used for randomizing the height of NPCs.")]
        [SynthesisTooltip("A higher seed value will result in more variation in height.")]
        public int HeightSeed { get; set; } = 100000;

        [SynthesisSettingName("Drop chance")]
        [SynthesisDescription("Goes from 0 to 100, it affects how likely schematics are to drop")]
        [SynthesisTooltip("Goes from 0 to 100, it affects how likely schematics are to drop")]
        public int DropChance { get; set; } = 20;

        // A dictionary to store the settings for each race and gender
        // The key is a string of the form "Race", e.g. "NordRace"
        // the "Default" entry is not an actual race but is used as the default if ScaleEverything is toggled on
        // The value is an instance of BaseSettings
        [SynthesisSettingName("Race and Gender Settings")]
        public Dictionary<string, BaseSettings> RaceGenderSettings { get; set; } = new()
        {
            { "Default",            new() { MinMaleHeightScale = 0.800, MaxMaleHeightScale = 1.200, MinFemaleHeightScale = 0.775, MaxFemaleHeightScale = 1.175 } },
            { "DefaultRace",        new() { MinMaleHeightScale = 0.900, MaxMaleHeightScale = 1.100, MinFemaleHeightScale = 0.775, MaxFemaleHeightScale = 1.075 } },
            { "ElderRace",          new() { MinMaleHeightScale = 0.800, MaxMaleHeightScale = 1.125, MinFemaleHeightScale = 0.775, MaxFemaleHeightScale = 1.100 } },


            { "HighElfRace",        new() { MinMaleHeightScale = 1.050, MaxMaleHeightScale = 1.150, MinFemaleHeightScale = 1.025, MaxFemaleHeightScale = 1.175 } },
            { "HighElfRaceVampire", new() { MinMaleHeightScale = 1.050, MaxMaleHeightScale = 1.150, MinFemaleHeightScale = 1.025, MaxFemaleHeightScale = 1.175 } },

            { "OrcRace",            new() { MinMaleHeightScale = 1.000, MaxMaleHeightScale = 1.100, MinFemaleHeightScale = 1.050, MaxFemaleHeightScale = 1.150 } },
            { "OrcRaceVampire",     new() { MinMaleHeightScale = 1.000, MaxMaleHeightScale = 1.100, MinFemaleHeightScale = 1.050, MaxFemaleHeightScale = 1.150 } },

            { "NordRace",           new() { MinMaleHeightScale = 1.050, MaxMaleHeightScale = 1.125, MinFemaleHeightScale = 1.000, MaxFemaleHeightScale = 1.150 } },
            { "NordRaceVampire",    new() { MinMaleHeightScale = 1.050, MaxMaleHeightScale = 1.125, MinFemaleHeightScale = 1.000, MaxFemaleHeightScale = 1.150 } },
            { "NordRaceChild",      new() { MinMaleHeightScale = 1.075, MaxMaleHeightScale = 1.075, MinFemaleHeightScale = 1.000, MaxFemaleHeightScale = 1.100 } },

            { "ArgonianRace",       new() { MinMaleHeightScale = 0.950, MaxMaleHeightScale = 1.100, MinFemaleHeightScale = 1.100, MaxFemaleHeightScale = 1.125 } },
            { "ArgonianRaceVampire",new() { MinMaleHeightScale = 0.950, MaxMaleHeightScale = 1.100, MinFemaleHeightScale = 1.100, MaxFemaleHeightScale = 1.125 } },

            { "RedguardRace",       new() { MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.075, MinFemaleHeightScale = 0.950, MaxFemaleHeightScale = 1.075 } },
            { "RedguardRaceVampire",new() { MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.075, MinFemaleHeightScale = 0.950, MaxFemaleHeightScale = 1.075 } },
            { "RedguardRaceChild",  new() { MinMaleHeightScale = 0.975, MaxMaleHeightScale = 1.075, MinFemaleHeightScale = 0.950, MaxFemaleHeightScale = 1.075 } },

            { "WoodElfRace",        new() { MinMaleHeightScale = 0.925, MaxMaleHeightScale = 1.075, MinFemaleHeightScale = 0.900, MaxFemaleHeightScale = 1.050 } },
            { "WoodElfRaceVampire", new() { MinMaleHeightScale = 0.925, MaxMaleHeightScale = 1.075, MinFemaleHeightScale = 0.900, MaxFemaleHeightScale = 1.050 } },

            { "BretonRace",         new() { MinMaleHeightScale = 0.900, MaxMaleHeightScale = 1.000, MinFemaleHeightScale = 0.875, MaxFemaleHeightScale = 1.025 } },
            { "BretonRaceVampire",  new() { MinMaleHeightScale = 0.900, MaxMaleHeightScale = 1.000, MinFemaleHeightScale = 0.875, MaxFemaleHeightScale = 1.025 } },
            { "BretonRaceChild",    new() { MinMaleHeightScale = 0.900, MaxMaleHeightScale = 1.000, MinFemaleHeightScale = 0.875, MaxFemaleHeightScale = 1.025 } },

            { "ImperialRace",       new() { MinMaleHeightScale = 0.875, MaxMaleHeightScale = 1.050, MinFemaleHeightScale = 0.850, MaxFemaleHeightScale = 1.050 } },
            { "ImperialRaceVampire",new() { MinMaleHeightScale = 0.875, MaxMaleHeightScale = 1.050, MinFemaleHeightScale = 0.850, MaxFemaleHeightScale = 1.050 } },
            { "ImperialRaceChild",  new() { MinMaleHeightScale = 0.875, MaxMaleHeightScale = 1.025, MinFemaleHeightScale = 0.950, MaxFemaleHeightScale = 1.050 } },

            { "DarkElfRace",        new() { MinMaleHeightScale = 0.850, MaxMaleHeightScale = 0.950, MinFemaleHeightScale = 0.825, MaxFemaleHeightScale = 1.000 } },
            { "DarkElfRaceVampire", new() { MinMaleHeightScale = 0.850, MaxMaleHeightScale = 0.950, MinFemaleHeightScale = 0.825, MaxFemaleHeightScale = 1.000 } },

            { "KhajiitRace",        new() { MinMaleHeightScale = 0.825, MaxMaleHeightScale = 0.925, MinFemaleHeightScale = 0.800, MaxFemaleHeightScale = 0.925 } },
            { "KhajiitRaceVampire", new() { MinMaleHeightScale = 0.825, MaxMaleHeightScale = 0.925, MinFemaleHeightScale = 0.800, MaxFemaleHeightScale = 0.925 } },



            { "SnowElfRace",        new() { MinMaleHeightScale = 1.050, MaxMaleHeightScale = 1.150, MinFemaleHeightScale = 1.025, MaxFemaleHeightScale = 1.175 } },
            { "FalmerRace",         new() { MinMaleHeightScale = 0.850, MaxMaleHeightScale = 0.950, MinFemaleHeightScale = 0.825, MaxFemaleHeightScale = 1.000 } },
            { "DA13AfflictedRace",  new() { MinMaleHeightScale = 0.900, MaxMaleHeightScale = 1.000, MinFemaleHeightScale = 0.875, MaxFemaleHeightScale = 1.025 } }
        };

        [SynthesisSettingName("Also patch furniture to disable scaling")]
        [SynthesisDescription("Removes the RaceToScale keyword from furniture")]
        [SynthesisTooltip("NPCs will be visibly changing height otherwise")]
        public bool PatchFurniture { get; set; } = true;

        [SynthesisSettingName("Also patch player record")]
        public bool PatchPlayerRecord { get; set; } = false;

        [SynthesisSettingName("Don't change custom heights")]
        [SynthesisDescription("If an NPC has a height value different from 1, it gets ignored when this is toggled")]
        [SynthesisTooltip("If an NPC has a height value different from 1, it gets ignored when this is toggled")]
        public bool OnlyReplaceDefaulted { get; set; } = false;

        [SynthesisSettingName("Scale everything (Uses 'Default' settings above)")]
        [SynthesisDescription("Uses the 'Default' preset above for every race that doesn't have settings set")]
        [SynthesisTooltip("Uses the 'Default' preset above for every race that doesn't have settings set")]
        public bool ScaleEverything { get; set; } = false;

        [SynthesisSettingName("(Debug) Show unpatched actors in logs")]
        public bool ShowDebugLogs { get; set; } = false;
    }
}