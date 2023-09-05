using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ModLoader;

namespace EquipPerks.Globals
{
	public class PetGlobalBuff : GlobalBuff
	{
        public override void Update(int type, Player player, ref int buffIndex)
        {
            player.TryGetModPlayer(out PerksPlayer perksPlayer);
            if (!perksPlayer.recievePetPerks)
            {
                return;
            }

            switch (type)
            {
                case 40: // Bunny
                    player.discountAvailable = true;
                    return;
                case 41: // Penguin
                    player.arcticDivingGear = true;
                    player.fishingSkill += 5;
                    return;
                case 42: // Turtle
                    if (player.wet)
                    {
                        player.runAcceleration *= 1.1f;
                        player.maxRunSpeed *= 1.1f;
                        player.accRunSpeed *= 1.1f;
                        player.runSlowdown *= 1.1f;
                    }
                    else
                    {
                        player.statDefense += 2;
                    }
                    return;
                case 45: // Eater of Souls
                    player.aggro -= 150;
                    return;
                case 50: // Dungeon Guardian
                    player.statDefense += 4;
                    player.GetDamage(DamageClass.Generic) += 0.05f;
                    return;
                case 51: // Hornet
                    player.buffImmune[BuffID.Poisoned] = true;
                    return;
                case 52: // Tiki
                    player.manaRegenBonus += 10;
                    player.GetKnockback(DamageClass.Magic) += 0.2f;
                    player.GetKnockback(DamageClass.Summon) += 0.2f;
                    return;
                case 53: // Lizard
                    if(player.statLife < player.statLifeMax2 * 0.5f)
                    {
                        player.runAcceleration *= 1.1f;
                        player.maxRunSpeed *= 1.1f;
                        player.accRunSpeed *= 1.1f;
                        player.runSlowdown *= 1.1f;
                        player.lifeRegen += 3;
                    }
                    return;
                case 54: // Parrot
                    player.GetCritChance(DamageClass.Ranged) += 4f;
                    return;
                case 55: // Truffle
                    player.buffImmune[BuffID.Confused] = true;
                    return;
                case 56: // Plantera Sapling
                    if (Main.dayTime)
                    {
                        player.lifeRegen += 3;
                    }
                    return;
                case 61: // Dino
                    player.buffImmune[BuffID.BrokenArmor] = true;
                    player.GetArmorPenetration(DamageClass.Melee) += 5;
                    return;
                case 65: // Eyezor Spring
                    player.jumpSpeedBoost += 1.4f;
                    player.GetCritChance(DamageClass.Generic) += 2f;
                    return;
                case 66: // Snowman
                    player.iceSkate = true;
                    player.buffImmune[BuffID.Chilled] = true;
                    return;
                case 81: // Spider
                    player.buffImmune[BuffID.Webbed] = true;
                    player.buffImmune[BuffID.Venom] = true;
                    return;
                case 82: // Squashling
                    player.statDefense -= 4;
                    player.lifeRegen += 3;
                    return;
                case 84: // Black Cat
                    perksPlayer.blackCat = true;
                    player.GetDamage(DamageClass.Magic) += 0.04f;
                    return;
                case 85: // Cursed Sapling
                    player.enemySpawns = true;
                    return;
                case 91: // Puppy 
                    player.buffImmune[BuffID.Weak] = true;
                    player.buffImmune[BuffID.Slow] = true;
                    player.equipmentBasedLuckBonus += 0.02f;
                    return;
                case 92: // Grinch 
                    if(player.chilled || player.frozen || player.onFrostBurn || Main.snowMoon)
                    {
                        player.GetDamage(DamageClass.Generic) += 0.1f;
                    }
                    return;
                case 127: // Zephyr Fish
                    player.fishingSkill += 10;
                    if (Main.raining)
                    {
                        player.fishingSkill += 10;
                    }
                    return;
                case 136: // Minotaur
                    player.GetAttackSpeed(DamageClass.Melee) += 0.05f;
                    player.aggro += 200;
                    return;
                case 154: // Face Monster
                    player.aggro -= 150;
                    return;
                case 191: // Companion Cube
                    if(!player.mount.Active)
                    {
                        if (!player.PortalPhysicsEnabled)
                        {
                            player.maxFallSpeed *= 2f;
                        }
                        else
                        {
                            player.lifeRegen += 3;
                        }
                    }
                    return;
                case 200: // DD2 Gato
                    if (DD2Event.Ongoing)
                    {
                        player.runAcceleration *= 1.1f;
                        player.maxRunSpeed *= 1.05f;
                        player.accRunSpeed *= 1.05f;
                        player.runSlowdown *= 1.1f;
                        player.jumpSpeedBoost += 1f;
                    }
                    player.GetDamage(DamageClass.Summon) += 0.02f;
                    return;
                case 202: // DD2 Dragon
                    if(DD2Event.Ongoing)
                    {
                        player.treasureMagnet = true;
                    }
                    player.GetDamage(DamageClass.Summon) += 0.02f;
                    return;
                case 217: // Luma
                    player.statManaMax2 += 20;
                    player.jumpSpeedBoost += 1f;
                    return;
                case 218: // Sugar Glider
                    player.extraFall += 10;
                    return;
                case 219: // Baby Shark
                    player.accFlipper = true;
                    player.fishingSkill += 5;
                    return;
                case 258: // Harpy
                    if (player.wings > 0)
                    {
                        player.wingTimeMax += 15;
                    }
                    return;
                case 259: // Fennec Fox
                    player.sonarPotion = true;
                    return;
                case 260: // Butterfly
                    if (Main.dayTime)
                    {
                        player.GetCritChance(DamageClass.Magic) += 3f;
                    }
                    player.GetCritChance(DamageClass.Magic) += 3f;
                    return;
                case 261: // Demon Imp
                    player.fireWalk = true;
                    player.buffImmune[BuffID.OnFire] = true;
                    return;
                case 262: // Red Panda
                    player.calmed = true;
                    return;
                case 264: // Plantero
                    if (player.statLife < player.statLifeMax2 * 0.5f)
                    {
                        player.GetAttackSpeed(DamageClass.Melee) += 0.05f;
                        player.GetAttackSpeed(DamageClass.SummonMeleeSpeed) += 0.05f;
                    }
                    player.whipRangeMultiplier += 0.05f;
                    return;
                case 266: // Dynamite Kitten
                    player.GetArmorPenetration(DamageClass.Ranged) += 10;
                    player.pickSpeed += 0.05f;
                    return;
                case 267: // Werewolf
                    if (!Main.dayTime)
                    {
                        player.GetDamage(DamageClass.Melee) += 0.04f;
                        player.GetAttackSpeed(DamageClass.Melee) += 0.04f;
                    }
                    return;
                case 268: // Mimic
                    player.fireWalk = true;
                    player.aggro -= 300;
                    return;
                case 274: // Pikachu
                    player.buffImmune[BuffID.Electrified] = true;
                    if (Main.IsItStorming)
                    {
                        player.runAcceleration *= 1.15f;
                        player.runSlowdown *= 1.15f;
                        player.maxRunSpeed *= 1.05f;
                        player.accRunSpeed *= 1.05f;
                    }
                    else
                    {
                        player.runAcceleration *= 1.1f;
                        player.runSlowdown *= 1.1f;
                    }
                    return;
                // Master Mode: //
                case 284: // King Slime
                    player.jumpSpeedBoost += 1.4f;
                    player.extraFall += 10;
                    return;
                case 285: // EoC
                    player.nightVision = true;
                    if (!Main.dayTime)
                    {
                        player.GetCritChance(DamageClass.Generic) += 4f;
                    }
                    return;
                case 286: // EoW
                    player.pickSpeed += 0.2f;
                    player.statDefense += 2;
                    return;
                case 287: // BoC
                    player.buffImmune[BuffID.Confused] = true;
                    player.lifeRegen += 2;
                    return;
                case 288: // Skeletron
                    player.buffImmune[BuffID.Cursed] = true;
                    player.buffImmune[BuffID.Bleeding] = true;
                    if (!Main.dayTime)
                    {
                        player.GetKnockback(DamageClass.Generic) += 0.25f;
                    }
                    return;
                case 289: // Queen Bee
                    player.honey = true;
                    player.buffImmune[BuffID.Poisoned] = true;
                    return;
                case 290: // Destroyer
                    player.pickSpeed += 0.3f;
                    player.statDefense += 4;
                    player.buffImmune[BuffID.BrokenArmor] = true;
                    return;
                case 291: // Twins
                    player.nightVision = true;
                    player.buffImmune[BuffID.Darkness] = true;
                    player.buffImmune[BuffID.Blackout] = true;
                    player.GetCritChance(DamageClass.Generic) += 5f;
                    return;
                case 292: // Prime
                    player.buffImmune[BuffID.Cursed] = true;
                    player.buffImmune[BuffID.Bleeding] = true;
                    player.GetKnockback(DamageClass.Generic) += 0.4f;
                    player.GetArmorPenetration(DamageClass.Generic) += 5;
                    return;
                case 293: // Plantera
                    player.thorns += 0.75f;
                    player.buffImmune[BuffID.Poisoned] = true;
                    player.buffImmune[BuffID.Venom] = true;
                    return;
                case 295: // Duke
                    if (player.wet || Main.raining || player.statLife < player.statLifeMax2 * 0.5f)
                    {
                        player.GetDamage(DamageClass.Generic) += 0.075f;
                        player.runAcceleration *= 1.05f;
                        player.maxRunSpeed *= 1.05f;
                        player.accRunSpeed *= 1.05f;
                        player.runSlowdown *= 1.05f;
                    }
                    player.accFlipper = true;
                    player.buffImmune[BuffID.Rabies] = true;
                    return;
                case 296: // Cultist
                    player.buffImmune[BuffID.Obstructed] = true;
                    player.buffImmune[BuffID.VortexDebuff] = true;
                    player.statLifeMax2 = (int)(player.statLifeMax2 * 0.9f);
                    player.GetCritChance(DamageClass.Magic) += 10f;
                    player.GetDamage(DamageClass.Summon) += 0.1f;
                    return;
                case 297: // Moon Lord
                    player.buffImmune[BuffID.MoonLeech] = true;
                    player.lifeRegen += 1;
                    player.lifeSteal += 0.007f;
                    return;
                case 300: // Everscream
                    if (Main.snowMoon)
                    {
                        player.statDefense += 4;
                        player.lifeRegen += 2;
                    }
                    player.resistCold = true;
                    return;
                case 301: // Ice Queen
                    if (Main.snowMoon)
                    {
                        player.GetDamage(DamageClass.Generic) += 0.1f;
                    }
                    player.buffImmune[BuffID.Frozen] = true;
                    player.buffImmune[BuffID.Chilled] = true;
                    player.buffImmune[BuffID.Frostburn] = true;
                    return;
                case 302: // Martians
                    player.runAcceleration *= 1.25f;
                    player.maxRunSpeed *= 1.05f;
                    player.accRunSpeed *= 1.05f;
                    player.runSlowdown *= 1.25f;
                    player.slowFall = true;
                    return;
                case 303: // DD2 Ogre
                    if (DD2Event.Ongoing)
                    {
                        player.noKnockback = true;
                        player.GetKnockback(DamageClass.Generic) += 0.5f;
                    }
                    player.GetDamage(DamageClass.Summon) += 0.04f;
                    player.buffImmune[BuffID.OgreSpit] = true;
                    return;
                case 304: // DD2 Betsy
                    if (DD2Event.Ongoing)
                    {
                        player.GetDamage(DamageClass.Generic) += 0.1f;
                    }
                    player.GetDamage(DamageClass.Summon) += 0.06f;
                    player.buffImmune[BuffID.OnFire] = true;
                    return;
                case 317: // Queen Slime
                    if(player.wings > 0)
                    {
                        player.wingTimeMax += 30;
                    }
                    else
                    {
                        player.jumpSpeedBoost += 0.7f;
                        player.noFallDmg = true;
                    }
                    player.jumpSpeedBoost += 0.7f;
                    return;
                case 329: // DST Deerclops
                    player.noKnockback = true;
                    player.buffImmune[BuffID.Frozen] = true;
                    player.buffImmune[BuffID.Slow] = true;
                    if (player.chilled)
                    {
                        player.statDefense += 2;
                    }
                    return;
                case 341: // King & Queen Slime
                    player.jumpSpeedBoost += 1.6f;
                    if (player.wings > 0)
                    {
                        player.wingTimeMax += 20;
                    }
                    else
                    {
                        player.jumpSpeedBoost += 0.6f;
                        player.noFallDmg = true;
                    }
                    return;
                // End Master Mode //
                case 327: // DST Bernie
                    player.lifeRegen += 2;
                    return;
                case 328: // DST Glommer
                    player.autoJump = true;
                    player.jumpSpeedBoost += 1f;
                    return;
                case 330: // DST Pig
                    int lifeBoost = (int)(player.statLifeMax2 * 1.1f) - player.statLifeMax2;
                    if(lifeBoost > 50)
                    {
                        lifeBoost = 50;
                    }
                    player.statLifeMax2 += lifeBoost;
                    player.GetDamage(DamageClass.Generic) -= 0.1f;
                    return;
                //case 152: // Chester
                    // N/A, already has a speical effect (Piggy Bank access)
                case 345: // Stardew Junimo
                    player.statManaMax2 += 20;
                    player.manaCost -= 0.04f;
                    return;
                case 349: // Stardew Chicken
                    perksPlayer.perkLuck += 0.05f;
                    player.extraFall += 5;
                    return;
                case 351: // Zomboid Spiffo
                    if (!Main.dayTime)
                    {
                        player.statDefense += 4;
                    }
                    return;
                case 352: // Core Caveling
                    player.pickSpeed += 0.1f;
                    return;
                case 354: // The Dirtiest Block
                    perksPlayer.perkLuck += 0.1f;
                    player.pickSpeed += 0.1f;
                    return;
                default:
                    return;
            }
        }
    }
}