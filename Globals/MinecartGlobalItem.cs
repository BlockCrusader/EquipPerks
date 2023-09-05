using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EquipPerks.Globals
{
	public class MinecartGlobalItem : GlobalItem
	{
        
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (!ModContent.GetInstance<PerksConfig>().cartTooltips)
            {
                return;
            }

            switch (item.type)
            {
                case 3353: // Mechanical (Expert)
                    tooltips.Insert(2, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartMech")));
                    return;
                case 4066: // Desert
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartDesert")));
                    return;
                case 4426: // Bee
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartBee")));
                    return;
                case 4427: // Ladybug
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.LuckBoost")));
                    return;
                case 4428: // Pigron
                    tooltips.Insert(2, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartPigron")));
                    return;
                case 4429: // Sunflower
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartSunflower")));
                    return;
                case 4450: // Shroom
                    tooltips.Insert(2, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartShroom")));
                    return;
                case 4451: // Amethyst 
                case 4452: // Topaz
                case 4453: // Sapphire
                case 4454: // Emerald
                case 4455: // Ruby
                case 4456: // Diamond
                case 4467: // Amber
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartGem")));
                    return;
                case 4468: // Beetle
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartBeetle")));
                    return;
                case 4469: // Meowmere
                    tooltips.Insert(2, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartMeowmere")));
                    return;
                case 4470: // Party
                    tooltips.Insert(2, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartParty")));
                    return;
                case 4471: // Dutchman
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartDutchman")));
                    return;
                case 4472: // Steampunk
                    tooltips.Insert(2, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartSteampunk")));
                    return;
                case 4745: // Coffin
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartCoffin")));
                    return;
                case 5125: // Fart Kart
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartFart")));
                    return;
                case 5288: // Terra
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.CartTerraFart")));
                    return;
                default:
                    return;
            }
        }
        
    }
}