using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EquipPerks.Globals
{
	public class PetGlobalItem : GlobalItem
    { 
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (!ModContent.GetInstance<PerksConfig>().petTooltips)
            {
                return;
            }

            switch (item.type)
            {
                case 603: // Bunny
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetBunny")));
                    return;
                case 669: // Penguin
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetPenguin")));
                    return;
                case 753: // Turtle
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetTurtle")));
                    return;
                case 994: // EoS
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetAggroDown")));
                    return;
                case 1169: // Dungeon Guardian
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetGuardian")));
                    return;
                case 1170: // Hornet
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetHornet")));
                    return;
                case 1171: // Tiki
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetTiki")));
                    return;
                case 1172: // Lizard
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetLizard")));
                    return;
                case 1180: // Parrot
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetParrot")));
                    return;
                case 1181: // Truffle
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetTruffle")));
                    return;
                case 1182: // Plantera Seedling
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetSeedling")));
                    return;
                case 1242: // Dino
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetDino")));
                    return;
                case 1311: // Eyezor Spring
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetEyezor")));
                    return;
                case 1312: // Snowman
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetSnowman")));
                    return;
                case 1798: // Spider
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetSpider")));
                    return;
                case 1799: // Squashling
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetSquashling")));
                    return;
                case 1810: // Black Cat
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetBlackCat")));
                    return;
                case 1837: // Cursed Sapling
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetCursedSapling")));
                    return;
                case 1927: // Puppy
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetPuppy")));
                    return;
                case 1959: // Grinch
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetGrinch")));
                    return;
                case 2420: // Zephyr Fish
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetZephyr")));
                    return;
                case 2587: // Minotaur
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetMinotaur")));
                    return;
                case 3060: // Face Monster
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetAggroDown")));
                    return;
                case 3628: // Companion Cube
                    tooltips.Insert(2, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetCube")));
                    return;
                case 3855: // DD2 Gato
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetGato")));
                    return;
                case 3857: // DD2 Dragon
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetDragon")));
                    return;
                case 4365: // Luma
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetTwink")));
                    return;
                case 4366: // Sugar Glider
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetSugarGlider")));
                    return;
                case 4425: // Baby Shark
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetShark")));
                    return;
                case 4550: // Red Panda
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetPanda")));
                    return;
                case 4551: // Fire Imp
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetImp")));
                    return;
                case 4603: // Harpy
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetHarpy")));
                    return;
                case 4604: // Fennec Fox
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetFennec")));
                    return;
                case 4605: // Butterfly
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetButterfly")));
                    return;
                case 4701: // Plantero
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetPlantero")));
                    return;
                case 4735: // Dynamite Kitten
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetDynamiteKitten")));
                    return;
                case 4736: // Werewolf
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetWerewolf")));
                    return;
                case 4737: // Mimic
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetMimic")));
                    return;
                case 4777: // Pikachu
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetPikachu")));
                    return;
                // Master Mode: //
                case 4797: // King Slime
                    tooltips.Insert(4, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetKS")));
                    return;
                case 4798: // EoC
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetEoC")));
                    return;
                case 4799: // EoW
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetEoW")));
                    return;
                case 4800: // BoC
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetBoC")));
                    return;
                case 4801: // Skeletron
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetSkeletron")));
                    return;
                case 4802: // Queen Bee
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetQB")));
                    return;
                case 4803: // Destroyer
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetDestroyer")));
                    return;
                case 4804: // Twins
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetTwins")));
                    return;
                case 4805: // Prime
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetPrime")));
                    return;
                case 4806: // Plantera
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetPlantera")));
                    return;
                case 4808: // Duke
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetDuke")));
                    return;
                case 4809: // Cultist
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetCultist")));
                    return;
                case 4810: // Moon Lord
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetML")));
                    return;
                case 4813: // Everscream
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetEverscream")));
                    return;
                case 4814: // Ice Queen
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetIQ")));
                    return;
                case 4815: // Martians
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetMartian")));
                    return;
                case 4816: // DD2 Ogre
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetOgre")));
                    return;
                case 4817: // DD2 Betsy
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetBetsy")));
                    return;
                case 4960: // Queen Slime
                    tooltips.Insert(4, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetQS")));
                    return;
                case 5090: // DST Deerclops
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetDeerclops")));
                    return;
                case 5131: // King & Queen Slime
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetSlimes")));
                    return;
                // End Master Mode //
                case 5088: // DST Bernie
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetBernie")));
                    return;
                case 5089: // DST Glommer
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetGlommer")));
                    return;
                case 5091: // DST Pig
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetPig")));
                    return;
                case 5276: // Stardew Junimo
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetJunimo")));
                    return;
                case 5297: // Stardew Chicken
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetChicken")));
                    return;
                case 5332: // Zomboid Spiffo
                    tooltips.Insert(2, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetSpiffo")));
                    return;
                case 5333: // Core Caveling
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetCaveling")));
                    return;
                case 5400: // The Dirtiest Block
                    tooltips.Insert(2, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.PetDirt")));
                    return;
                default:
                    return;
            }
        }
    }
}