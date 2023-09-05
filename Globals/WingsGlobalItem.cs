using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EquipPerks.Globals
{
	public class WingsGlobalItem : GlobalItem
	{
        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return entity.wingSlot > 0;
        }

        public override void UpdateEquip(Item item, Player player)
        {
            player.TryGetModPlayer(out PerksPlayer perksPlayer);
            if (!perksPlayer.recieveWingPerks)
            {
                return;
            }

            switch (item.type)
            {
                // case 4978: // Fledgling
                    // N/A, first wings, nothing special needed
                case 493: // Angel
                    player.lifeRegen++;
                    return;
                case 492: // Demon
                    player.GetDamage(DamageClass.Generic) += 0.02f;
                    return;
                case 761: // Fairy
                    if (player.statLife < player.statLifeMax2 * 0.25f)
                    {
                        player.lifeRegen += 3;
                    }
                    return;
                case 2494: // Fin
                    player.accFlipper = true;
                    return;
                case 822: // Frozen
                    player.buffImmune[BuffID.Frozen] = true;
                    player.buffImmune[BuffID.Chilled] = true;
                    return;
                case 785: // Harpy
                    player.jumpSpeedBoost += 1f;
                    return;
                case 748: // Jetpack
                    player.GetAttackSpeed(DamageClass.Ranged) += 0.03f;
                    return;
                case 665: // Red's
                case 1583: // D-Town's
                case 1584: // Will's
                case 1585: // Crowno's
                case 1586: // Cenx's
                case 3228: // Lazure's
                case 3580: // Yorai's
                case 3582: // Jim's
                case 3588: // Skiphs'
                case 3592: // Loki's
                case 3924: // Arkhalis'
                case 3928: // Leinfors'
                case 4730: // Ghostar's
                case 4746: // Safeman's
                case 4750: // FoodBarbarian's
                case 4754: // Grox's
                    player.equipmentBasedLuckBonus += 0.05f;
                    return;
                case 1162: // Leaf
                    player.whipRangeMultiplier += 0.05f;
                    player.GetAttackSpeed(DamageClass.SummonMeleeSpeed) += 0.02f;
                    return;
                case 1165: // Bat
                    if (!Main.dayTime)
                    {
                        player.lifeSteal += 0.01f;
                    }
                    return;
                case 1515: // Bee
                    player.lifeRegen++;
                    player.buffImmune[BuffID.Poisoned] = true;
                    return;
                case 749: // Butterfly
                    if (Main.dayTime)
                    {
                        player.lifeRegen += 2;
                    }
                    else
                    {
                        player.manaRegenBonus += 10;
                    }
                    return;
                case 821: // Flame
                    player.buffImmune[BuffID.OnFire] = true;
                    player.buffImmune[BuffID.Frostburn] = true;
                    player.buffImmune[BuffID.CursedInferno] = true;
                    player.fireWalk = true;
                    return;
                case 823: // Spectre
                    if (player.statLife < player.statLifeMax2 * 0.5f)
                    {
                        player.lifeSteal += 0.007f;
                    }
                    else
                    {
                        player.GetDamage(DamageClass.Magic) += 0.04f;
                    }
                    return;
                case 1866: // Hoverboard
                    player.GetDamage(DamageClass.Ranged) += 0.04f;
                    return;
                case 786: // Bone
                    if (player.statLife < player.statLifeMax2 * 0.5f)
                    {
                        player.statDefense += 2;
                    }
                    if (player.statLife < player.statLifeMax2 * 0.25f)
                    {
                        player.statDefense += 2;
                    }
                    return;
                case 2770: // Mothron
                    if (Main.eclipse)
                    {
                        player.GetCritChance(DamageClass.Generic) += 3f;
                        player.lifeRegen += 2;
                    }
                    else if (!Main.dayTime)
                    {
                        player.lifeRegen += 2;
                    }
                    return;
                case 2280: // Beetle
                    if (player.statLife < player.statLifeMax2 * 0.5f)
                    {
                        player.statDefense += 2;
                    }
                    else
                    {
                        player.GetArmorPenetration(DamageClass.Melee) += 10;
                    }
                    return;
                case 1871: // Festive
                    player.resistCold = true;
                    return;
                case 1830: // Spooky
                    player.GetDamage(DamageClass.Summon) += 0.03f;
                    player.GetKnockback(DamageClass.Summon) += 0.2f;
                    return;
                case 1797: // Tattered Fairy
                    if(player.lifeRegen >= 1)
                    {
                        player.lifeRegen--;
                    }
                    if (player.statLife < player.statLifeMax2 * 0.5f)
                    {
                        player.manaRegenBonus += 5;
                    }
                    if (player.statLife < player.statLifeMax2 * 0.25f)
                    {
                        player.manaRegenBonus += 10;
                    }
                    return;
                case 948: // Steampunk
                    player.runAcceleration *= 1.1f;
                    player.runSlowdown *= 1.1f;
                    return;
                case 3883: // Betsy
                    if (DD2Event.Ongoing)
                    {
                        player.GetDamage(DamageClass.Generic) += 0.03f;
                        player.GetKnockback(DamageClass.Generic) += 0.15f;
                    }
                    player.buffImmune[BuffID.OnFire] = true;
                    return;
                case 4823: // Empress
                    if (Main.dayTime)
                    {
                        player.GetDamage(DamageClass.Generic) += 0.02f;
                    }
                    else
                    {
                        player.statDefense += 2;
                    }
                    return;
                case 2609: // Fishron
                    if (player.wet || Main.raining || player.statLife < player.statLifeMax2 * 0.5f)
                    {
                        player.GetDamage(DamageClass.Generic) += 0.03f;
                        player.runAcceleration *= 1.2f;
                        player.runSlowdown *= 1.2f;
                    }
                    return;
                case 3470: // Nebula
                    player.manaCost -= 0.12f;
                    return;
                case 3469: // Vortex
                    player.GetCritChance(DamageClass.Ranged) += 6f;
                    return;
                case 3468: // Solar
                    player.GetAttackSpeed(DamageClass.Melee) += 0.06f;
                    return;
                case 3471: // Stardust
                    player.GetDamage(DamageClass.Summon) += 0.06f;
                    return;
                case 4952: // Warp Star (Expert)
                    player.lifeRegen += 2;
                    player.manaRegenBonus += 10;
                    return;
                default:
                    return;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (!ModContent.GetInstance<PerksConfig>().wingTooltips)
            {
                return;
            }
            if (item.social)
            {
                return;
            }

            switch (item.type)
            {
                // case 4978: // Fledgling
                // N/A, first wings, nothing special needed
                case 493: // Angel
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsAngel")));
                    return;
                case 492: // Demon
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsDemon")));
                    return;
                case 761: // Fairy
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsFairy")));
                    return;
                case 2494: // Fin
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsFin")));
                    return;
                case 822: // Frozen
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsFrozen")));
                    return;
                case 785: // Harpy
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsHarpy")));
                    return;
                case 748: // Jetpack
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsJetpack")));
                    return;
                case 665: // Red's
                case 1583: // D-Town's
                case 1584: // Will's
                case 1585: // Crowno's
                case 1586: // Cenx's
                case 3582: // Jim's
                case 3588: // Skiphs' 
                case 3924: // Arkhalis'
                case 4754: // Grox's
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.LuckBoost")));
                    return;
                case 3228: // Lazure's
                case 3580: // Yorai's
                case 3592: // Loki's
                case 3928: // Leinfors'
                case 4730: // Ghostar's
                case 4746: // Safeman's
                case 4750: // FoodBarbarian's
                    tooltips.Insert(4, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.LuckBoost")));
                    return;
                case 1162: // Leaf
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsLeaf")));
                    return;
                case 1165: // Bat
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsBat")));
                    return;
                case 1515: // Bee
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsBee")));
                    return;
                case 749: // Butterfly
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsButterfly")));
                    return;
                case 821: // Flame
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsFlame")));
                    return;
                case 823: // Spectre
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsSpectre")));
                    return;
                case 1866: // Hoverboard
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsHoverboard")));
                    return;
                case 786: // Bone
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsBone")));
                    return;
                case 2770: // Mothron
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsMothron")));
                    return;
                case 2280: // Beetle
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsBeetle")));
                    return;
                case 1871: // Festive
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsFestive")));
                    return;
                case 1830: // Spooky
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsSpooky")));
                    return;
                case 1797: // Tattered Fairy
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsTatteredFairy")));
                    return;
                case 948: // Steampunk
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsSteampunk")));
                    return;
                case 3883: // Betsy
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsBetsy")));
                    return;
                case 4823: // Empress
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsEmpress")));
                    return;
                case 2609: // Fishron
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsFishron")));
                    return;
                case 3470: // Nebula
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsNebula")));
                    return;
                case 3469: // Vortex
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsVortex")));
                    return;
                case 3468: // Solar
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsSolar")));
                    return;
                case 3471: // Stardust
                    tooltips.Add(new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsStardust")));
                    return;
                case 4954: // Warp Star (Expert)
                    tooltips.Insert(6, new(Mod, "Perk", Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Perks.WingsWarpStar")));
                    return;
                default:
                    return;
            }
        }
    }
}