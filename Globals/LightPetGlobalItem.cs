using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EquipPerks.Globals
{
	public class LightPetGlobalItem : GlobalItem
	{
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (!ModContent.GetInstance<PerksConfig>().lightTooltips)
            {
                return;
            }

            switch (item.type)
            {
                case 115: // Shadow Orb
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.LightShadowOrb")));
                    return;
                case 425: // Faries
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.LightFairy")));
                    return;
                case 1183: // Wisp
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.LightWisp")));
                    return;
                case 3062: // Crimson Heart
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.LightHeart")));
                    return;
                case 3856: // Flickerwick
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.LightFlickerwick")));
                    return;
                case 3577: // Suspicious Eye (Expert)
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.LightML")));
                    return;
                // Master Mode: //
                case 4807: // Golem
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.LightGolem")));
                    return;
                case 4811: // EoL
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.LightEoL")));
                    return;
                case 4812: // Pumpking
                    tooltips.Insert(3, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.LightPumpking")));
                    return;
                // End Master Mode //
                default:
                    return;
            }
        }
    }
}