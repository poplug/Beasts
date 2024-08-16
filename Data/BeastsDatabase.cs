using System.Collections.Generic;

namespace Beasts.Data;

public static class BeastsDatabase
{
    public static List<Beast> AllBeasts = new()
    {
        new Beast
        {
            DisplayName = "Vivid Watcher",
            Path = "Metadata/Monsters/LeagueHarvest/Green/HarvestSquidT3MemoryLine_",
            Crafts =
            ["Transform an Item: Reroll an Awakened Support Gem"]
        },
        new Beast
        {
            DisplayName = "Vivid Vulture",
            Path = "Metadata/Monsters/LeagueHarvest/Green/HarvestVultureParasiteT3MemoryLine",
            Crafts = ["Transform an Item: Reroll a Synthesis Implicit Modifier"]
        },
        new Beast
        {
            DisplayName = "Vivid Abberarach",
            Path = "Metadata/Monsters/LeagueHarvest/Green/HarvestPlatedScorpionT3MemoryLine",
            Crafts = ["Create an Item: Shaper Guardian, Elder Guardian or Conqueror Map"]
        },
        new Beast
        {
            DisplayName = "Wild Brambleback",
            Path = "Metadata/Monsters/LeagueHarvest/Red/HarvestBrambleHulkT3MemoryLine",
            Crafts =
            [
                "Transform an Item: Increase level of non-Corrupted Awakened Gem by 1"
            ]
        },
        new Beast
        {
            DisplayName = "Wild Hellion Alpha",
            Path = "Metadata/Monsters/LeagueHarvest/Red/HarvestHellionT3MemoryLine",
            Crafts =
            [
                "Modify Mods on an Item: Reroll a Watcher's Eye Modifier"
            ]
        },
        new Beast
        {
            DisplayName = "Wild Bristle Matron",
            Path = "Metadata/Monsters/LeagueHarvest/Red/HarvestBeastT3MemoryLine_",
            Crafts =
            [
                "Modify Mods on an Item: Add a crafted Meta-modifier to a non-Unique Item"
            ]
        },
        new Beast
        {
            DisplayName = "Primal Crushclaw",
            Path = "Metadata/Monsters/LeagueHarvest/Blue/HarvestNessaCrabT3MemoryLine_",
            Crafts =
            [
                "Gain Atlas Crafts: Gain a free use of each Map Crafting Option"
            ]
        },
        new Beast
        {
            DisplayName = "Primal Cystcaller",
            Path = "Metadata/Monsters/LeagueHarvest/Blue/HarvestGoatmanT3MemoryLine",
            Crafts =
            [
                "Gain Atlas Crafts: Gain one of each Atlas Mission"
            ]
        },
        new Beast
        {
            DisplayName = "Primal Rhex Matriarch",
            Path = "Metadata/Monsters/LeagueHarvest/Blue/HarvestRhexT3MemoryLine",
            Crafts =
            [
                "Create an Item: Synthesis Unique Map"
            ]
        },
        new Beast
        {
            DisplayName = "Black Mórrigan",
            Path = "Metadata/Monsters/LeagueAzmeri/GullGoliathBestiary_",
            Crafts =
            [
                "Craft an Aspect Skill onto an Item: Level 30 Aspect of the Cat skill",
                "Craft an Aspect Skill onto an Item: Level 30 Aspect of the Avian skill",
                "Craft an Aspect Skill onto an Item: Level 30 Aspect of the Spider skill",
                "Craft an Aspect Skill onto an Item: Level 30 Aspect of the Crab skill",
                "Apply a Hinekora's Lock: To a Magic Item",
                "Split an Item: Into Three Items, with Two Mods on Each Item - Does not work on Influenced or Split items",
                "Modify an Item: to Have Maximum Possible Links",
                "Modify an Item: to Have Maximum Possible Number of Sockets",
            ]
        },
        new Beast
        {
            DisplayName = "Vivid Vulture",
            Path = "Metadata/Monsters/LeagueHarvest/Green/HarvestVultureParasiteT3",
            Crafts = ["Transform an Item: Reroll a Synthesis Implicit Modifier"]
        },
        new Beast
        {
            DisplayName = "Craicic Chimeral",
            Path = "Metadata/Monsters/LeagueBestiary/GemFrogBestiary",
            Crafts =
            [
                "Create an Imprint: Of a Magic Item"
            ]
        },
        new Beast
        {
            DisplayName = "Wild Hellion Alpha",
            Path = "Metadata/Monsters/LeagueHarvest/Red/HarvestHellionT3",
            Crafts =
            [
                "Modify Mods on an Item: Reroll a Watcher's Eye Modifier"
            ]
        },
        new Beast
        {
            DisplayName = "Wild Bristle Matron",
            Path = "Metadata/Monsters/LeagueHarvest/Red/HarvestBeastT3",
            Crafts =
            [
                "Modify Mods on an Item: Add a crafted Meta-modifier to a non-Unique Item"
            ]
        },
        new Beast
        {
            DisplayName = "Fenumus, First of the Night",
            Path = "Metadata/Monsters/LeagueBestiary/SpiderPlatedBestiarySpiritBoss",
            Crafts =
            [
                "Craft an Aspect Skill onto an Item: Aspect of the Spider skill"
            ]
        },
        new Beast
        {
            DisplayName = "Vivid Watcher",
            Path = "Metadata/Monsters/LeagueHarvest/Green/HarvestSquidT3_",
            Crafts =
            [
                "Transform an Item: Reroll an Awakened Support Gem"
            ]
        },
        new Beast
        {
            DisplayName = "Farrul, First of the Plains",
            Path = "Metadata/Monsters/LeagueBestiary/TigerBestiarySpiritBoss",
            Crafts =
            [
                "Craft an Aspect Skill onto an Item: Aspect of the Cat skill"
            ]
        },
        new Beast
        {
            DisplayName = "Saqawal, First of the Sky",
            Path = "Metadata/Monsters/LeagueBestiary/MarakethBirdSpiritBoss",
            Crafts =
            [
                "Craft an Aspect Skill onto an Item: Aspect of the Avian skill"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Frost Hellion Alpha",
            Path = "Metadata/Monsters/LeagueBestiary/HellionBestiary2",
            Crafts =
            [
                "Create Currency Items: A Stack of 3 Orbs of Horizons",
                "Transform an Item: From a Gilded Scarab to a Winged Scarab"
            ]
        },
        new Beast
        {
            DisplayName = "Craiceann, First of the Deep",
            Path = "Metadata/Monsters/LeagueBestiary/NessaCrabBestiarySpiritBoss",
            Crafts =
            [
                "Craft an Aspect Skill onto an Item: Aspect of the Crab skill"
            ]
        },
        new Beast
        {
            DisplayName = "Wild Brambleback",
            Path = "Metadata/Monsters/LeagueHarvest/Red/HarvestBrambleHulkT3",
            Crafts =
            [
                "Transform an Item: Increase level of non-Corrupted Awakened Gem by 1"
            ]
        },
        new Beast
        {
            DisplayName = "Primal Rhex Matriarch",
            Path = "Metadata/Monsters/LeagueHarvest/Blue/HarvestRhexT3",
            Crafts =
            [
                "Create an Item: Synthesis Unique Map"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Tiger Alpha",
            Path = "Metadata/Monsters/LeagueBestiary/TigerBestiary",
            Crafts =
            [
                "Open a Portal: to Farrul's Den"
            ]
        },
        new Beast
        {
            DisplayName = "Fenumal Plagued Arachnid",
            Path = "Metadata/Monsters/LeagueBestiary/SpiderPlagueBestiary",
            Crafts =
            [
                "Split an Item Into Two: With Half the Mods on Each Item"
            ]
        },
        new Beast
        {
            DisplayName = "Fenumal Hybrid Arachnid",
            Path = "Metadata/Monsters/LeagueBestiary/SpiderPlatedBestiary",
            Crafts =
            [
                "Open a Portal: to Fenumus' Lair"
            ]
        },
        new Beast
        {
            DisplayName = "Saqawine Rhex",
            Path = "Metadata/Monsters/LeagueBestiary/Avians/MarakethBirdBestiary",
            Crafts =
            [
                "Open a Portal: to Saqawal's Roost"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Wolf Alpha",
            Path = "Metadata/Monsters/LeagueBestiary/WolfBestiary",
            Crafts =
            [
                "Modify Mods on an Item: Add a Prefix, Remove a Random Suffix"
            ]
        },
        new Beast
        {
            DisplayName = "Craicic Spider Crab",
            Path = "Metadata/Monsters/LeagueBestiary/CrabSpiderBestiary",
            Crafts =
            [
                "Open a Portal: to Craiceann's Cove"
            ]
        },
        new Beast
        {
            DisplayName = "Primal Crushclaw",
            Path = "Metadata/Monsters/LeagueHarvest/Blue/HarvestNessaCrabT3",
            Crafts =
            [
                "Gain Atlas Crafts: Gain a free use of each Map Crafting Option"
            ]
        },
        new Beast
        {
            DisplayName = "Craicic Vassal",
            Path = "Metadata/Monsters/LeagueBestiary/ParasiticSquidBestiary",
            Crafts =
            [
                "Corrupt an Item: To have 30% Quality",
                "Corrupt an Item: Double Corrupt a Map"
            ]
        },
        new Beast
        {
            DisplayName = "Vivid Abberarach",
            Path = "Metadata/Monsters/LeagueHarvest/Green/HarvestPlatedScorpionT3",
            Crafts =
            [
                "Create an Item: Shaper Guardian, Elder Guardian or Conqueror Map"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Lynx Alpha",
            Path = "Metadata/Monsters/LeagueBestiary/LynxBestiary",
            Crafts =
            [
                "Modify Mods on an Item: Add a Suffix, Remove a Random Prefix"
            ]
        },
        new Beast
        {
            DisplayName = "Craicic Maw",
            Path = "Metadata/Monsters/LeagueBestiary/FrogBestiary",
            Crafts =
            [
                "Modify Mods on an Item: Add a Mod to a Shaper Item",
                "Modify Mods on an Item: Add a Mod to an Elder Item",
                "Modify Mods on an Item: Add a Mod to a Redeemer Item",
                "Modify Mods on an Item: Add a Mod to a Hunter Item",
                "Modify Mods on an Item: Add a Mod to a Crusader Item",
                "Modify Mods on an Item: Add a Mod to a Warlord Item"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Ape",
            Path = "Metadata/Monsters/LeagueBestiary/MonkeyBloodBestiary",
            Crafts =
            [
                "Create a Unique: Belt"
            ]
        },
        new Beast
        {
            DisplayName = "Primal Cystcaller",
            Path = "Metadata/Monsters/LeagueHarvest/Blue/HarvestGoatmanT3",
            Crafts =
            [
                "Gain Atlas Crafts: Gain one of each Atlas Mission"
            ]
        },
        new Beast
        {
            DisplayName = "Craicic Savage Crab",
            Path = "Metadata/Monsters/LeagueBestiary/CrabParasiteLargeBestiary_",
            Crafts =
            [
                "Create a Unique: Item",
                "Modify Mods on an Item: Add a Mod to a Rare Map"
            ]
        },
        new Beast
        {
            DisplayName = "Saqawine Vulture",
            Path = "Metadata/Monsters/LeagueBestiary/VultureBestiary",
            Crafts =
            [
                "Create an Item: Fully-linked Six-socket Rare"
            ]
        },
        new Beast
        {
            DisplayName = "Saqawine Cobra",
            Path = "Metadata/Monsters/LeagueBestiary/SnakeBestiary1",
            Crafts =
            [
                "Create a Unique: Mace or Sceptre"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Pit Hound",
            Path = "Metadata/Monsters/LeagueBestiary/PitbullBestiary",
            Crafts =
            [
                "Create an Item: Level 21 Corrupted Gem"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Ursa",
            Path = "Metadata/Monsters/LeagueBestiary/DropBearBestiary",
            Crafts =
            [
                "Create a Unique: Body Armour"
            ]
        },
        new Beast
        {
            DisplayName = "Fenumal Queen",
            Path = "Create a Unique: Staff",
            Crafts =
            [
                "Metadata/Monsters/LeagueBestiary/InsectSpawnerBestiary",
                "Modify Mods on an Item: Add a Mod to a Redeemer Item"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Goliath",
            Path = "Metadata/Monsters/LeagueBestiary/BestiarySpiker",
            Crafts =
            [
                "Create a Unique: Bow",
                "Modify Mods on an Item: Add a Mod to a Crusader Item"
            ]
        },
        new Beast
        {
            DisplayName = "Fenumal Devourer",
            Path = "Metadata/Monsters/LeagueBestiary/RootSpiderBestiary_",
            Crafts =
            [
                "Create a Unique: Shield or Quiver",
                "Modify Mods on an Item: Add a Mod to a Shaper Item"
            ]
        },
        new Beast
        {
            DisplayName = "Craicic Watcher",
            Path = "Metadata/Monsters/LeagueBestiary/SquidBestiary",
            Crafts =
            [
                "Create a Unique: Claw or Dagger",
                "Modify Mods on an Item: Add a Mod to a Hunter Item"
            ]
        },
        new Beast
        {
            DisplayName = "Saqawine Chimeral",
            Path = "Metadata/Monsters/LeagueBestiary/IguanaBestiary",
            Crafts =
            [
                "Create Currency Items: A Stack of 10 Random Currency"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Magma Hound",
            Path = "Metadata/Monsters/LeagueBestiary/HoundBestiary",
            Crafts =
            [
                "Create an Item: 23% Quality Corrupted Gem"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Taurus",
            Path = "Metadata/Monsters/LeagueBestiary/BestiaryBull",
            Crafts =
            [
                "Create a Unique: Map"
            ]
        },
        new Beast
        {
            DisplayName = "Craicic Squid",
            Path = "Metadata/Monsters/LeagueBestiary/SeaWitchSpawnBestiary",
            Crafts =
            [
                "Create a Rare: Talisman"
            ]
        },
        new Beast
        {
            DisplayName = "Craicic Shield Crab",
            Path = "Metadata/Monsters/LeagueBestiary/ShieldCrabBestiary",
            Crafts =
            [
                "Create Currency Items: A Stack of 4 Jeweller's Orbs",
                "Create Currency Items: A Stack of 2 Orbs of Binding"
            ]
        },
        new Beast
        {
            DisplayName = "Craicic Sand Spitter",
            Path = "Metadata/Monsters/LeagueBestiary/SandSpitterBestiary",
            Crafts =
            [
                "Create Currency Items: Orb of Fusing",
                "Create Currency Items: A Stack of 2 Orbs of Binding"
            ]
        },
        new Beast
        {
            DisplayName = "Fenumal Widow",
            Path = "Metadata/Monsters/LeagueBestiary/Spider5Bestiary",
            Crafts =
            [
                "Create a Unique: Gloves"
            ]
        },
        new Beast
        {
            DisplayName = "Saqawine Rhoa",
            Path = "Metadata/Monsters/LeagueBestiary/RhoaBestiary",
            Crafts =
            [
                "Create Currency Items: A Stack of 8 Chromatic Orbs"
            ]
        },
        new Beast
        {
            DisplayName = "Fenumal Scorpion",
            Path = "Metadata/Monsters/LeagueBestiary/BlackScorpionBestiary",
            Crafts =
            [
                "Corrupt an Item: Double Corrupt a Map",
                "Convert this Unique Item: Into Another Random Unique Item"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Flame Hellion Alpha",
            Path = "Metadata/Monsters/LeagueBestiary/HellionBestiary",
            Crafts =
            [
                "Create a Unique: Ring"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Chieftain",
            Path = "Metadata/Monsters/LeagueBestiary/BestiaryMonkeyChiefBlood",
            Crafts =
            [
                "Create a Unique: Amulet"
            ]
        },
        new Beast
        {
            DisplayName = "Saqawine Retch",
            Path = "Metadata/Monsters/LeagueBestiary/KiwethBestiary",
            Crafts =
            [
                "Create a Unique: Boots"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Goatman",
            Path = "Metadata/Monsters/LeagueBestiary/GoatmanLeapSlamBestiary",
            Crafts =
            [
                "Create a Unique: Flask"
            ]
        },
        new Beast
        {
            DisplayName = "Saqawine Blood Viper",
            Path = "Metadata/Monsters/LeagueBestiary/SnakeBestiary2",
            Crafts =
            [
                "Create a Unique: Sword or Axe",
                "Modify Mods on an Item: Add a Mod to an Elder Item"
            ]
        },
        new Beast
        {
            DisplayName = "Fenumal Scrabbler",
            Path = "Metadata/Monsters/LeagueBestiary/SandLeaperBestiary",
            Crafts =
            [
                "Create a Unique: Wand",
                "Modify Mods on an Item: Add a Mod to a Warlord Item"
            ]
        },
        new Beast
        {
            DisplayName = "Farric Gargantuan",
            Path = "Metadata/Monsters/LeagueBestiary/BeastCaveBestiary",
            Crafts =
            [
                "Create Currency Items: A Stack of 3 Orbs of Horizons",
                "Create a Unique: Helmet"
            ]
        }
    };

}