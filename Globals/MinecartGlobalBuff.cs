using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ModLoader;

namespace EquipPerks.Globals
{
	public class MinecartGlobalBuff : GlobalBuff
	{
        public override void Update(int type, Player player, ref int buffIndex)
        {
            player.TryGetModPlayer(out PerksPlayer perksPlayer);
            if (!perksPlayer.recieveMinecartPerks)
            {
                return;
            }

            switch (type)
            {
                case 166:
                case 167: // Mechanical (Expert)
                    player.statDefense += 3;
                    player.GetArmorPenetration(DamageClass.Generic) += 5f;
                    return;
                case 208:
                case 209: // Desert
                    player.equippedAnyTileRangeAcc = true;
                    player.pickSpeed += 0.15f;
                    return;
                //case 210:
                //case 211: // Minecarp
                    // N/A, already has special effect (Ignores water)
                case 220:
                case 221: // Bee
                    player.honey = true;
                    return;
                case 222:
                case 223: // Ladybug
                    perksPlayer.perkLuck += 0.05f;
                    return;
                case 224:
                case 225: // Pigron
                    player.arcticDivingGear = true;
                    player.aggro -= 300;
                    return;
                case 226:
                case 227: // Sunflower
                    player.sunflower = true;
                    return;
                //case 228:
                //case 229: // Demonic
                    // N/A, already has special effect (Lava immunity)
                case 231:
                case 232: // Shroom
                    player.nightVision = true;
                    return;
                case 233:
                case 234: // Amethyst
                case 235:
                case 236: // Topaz
                case 237:
                case 238: // Sapphire
                case 239:
                case 240: // Emerald
                case 241:
                case 242: // Ruby
                case 243:
                case 244: // Diamond
                case 245:
                case 246: // Amber
                    player.statDefense += 1;
                    return;
                case 247:
                case 248: // Bettle
                    player.statDefense += 2;
                    player.GetKnockback(DamageClass.Melee) += 0.25f;
                    return;
                case 249:
                case 250: // Meowmere
                    player.lifeRegen += 2;
                    player.GetAttackSpeed(DamageClass.Melee) += 0.05f;
                    return;
                case 251:
                case 252: // Party
                    if(player.meleeEnchant == 0)
                    {
                        player.meleeEnchant = 7;
                    }
                    if(BirthdayParty.PartyIsUp && BirthdayParty.GenuineParty)
                    {
                        perksPlayer.perkLuck += 0.05f;
                        player.lifeRegen += 1;
                    }
                    return;
                case 253:
                case 254: // Dutchman
                    player.meleeEnchant = 4;
                    return;
                case 255:
                case 256: // Steampunk
                    player.GetAttackSpeed(DamageClass.Ranged) += 0.05f;
                    return;
                case 269:
                case 270: // Coffin
                    if (player.statLife < player.statLifeMax2 * 0.5f)
                    {
                        player.statDefense += 4;
                    }
                    return;
                //case 272:
                //case 273: // Molecart
                    // N/A, already has special effect (Digging)
                case 338:
                case 339: // Fart Kart
                    player.aggro -= 200;
                    return;
                case 346:
                case 347: // Terra
                    player.aggro -= 200;
                    player.GetDamage(DamageClass.Generic) += 0.05f;
                    return;
                default:
                    return;
            }
        }
    }
}