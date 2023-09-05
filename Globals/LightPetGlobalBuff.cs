using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ModLoader;

namespace EquipPerks.Globals
{
	public class LightPetGlobalBuff : GlobalBuff
	{
        public override void Update(int type, Player player, ref int buffIndex)
        {
            player.TryGetModPlayer(out PerksPlayer perksPlayer);
            if (!perksPlayer.recieveLightPerks)
            {
                return;
            }

            switch (type)
            {
                case 19: // Shadow Orb
                    if (!Main.dayTime)
                    {
                        player.statDefense++;
                    }
                    return;
                case 27:
                case 101: // Faries
                case 102:
                    if (player.statLife < player.statLifeMax2 * 0.25f)
                    {
                        player.lifeRegen += 3;
                    }
                    return;
                case 57: // Wisp
                    if (player.statLife < player.statLifeMax2 * 0.1f)
                    {
                        player.manaRegenBonus += 10;
                    }
                    else if (player.statLife < player.statLifeMax2 * 0.25f)
                    {
                        player.manaRegenBonus += 8;
                    }
                    else if (player.statLife < player.statLifeMax2 * 0.5f)
                    {
                        player.manaRegenBonus += 5;
                    }
                    return;
                //case 152: // Magic Lantern
                    // N/A, already has a speical effect (Treasure sparkle FX)
                case 155: // Crimson Heart
                    if (player.statLife < player.statLifeMax2 * 0.5f)
                    {
                        player.lifeRegen++;
                    }
                    return;
                case 201: // DD2 Flickerwick
                    if (DD2Event.Ongoing)
                    {
                        player.buffImmune[BuffID.OnFire] = true;
                        player.buffImmune[BuffID.CursedInferno] = true;
                        player.buffImmune[BuffID.Frostburn] = true;
                        player.GetDamage(DamageClass.Magic) += 0.01f;
                        player.GetDamage(DamageClass.Summon) += 0.01f;
                    }
                    return;
                case 190: // Suspicious Eye (Expert)
                    player.buffImmune[BuffID.Darkness] = true;
                    player.buffImmune[BuffID.Blackout] = true;
                    player.buffImmune[BuffID.Obstructed] = true;
                    // Also has vanilla special effect (Treasure detection)
                    return;
                // Master Mode: //
                case 294: // Golem
                    if (player.IsStandingStillForSpecialEffects)
                    {
                        player.statDefense += 6;
                    }
                    player.statDefense += 3;
                    return;
                case 298: // EoL
                    if (Main.dayTime)
                    {
                        player.GetDamage(DamageClass.Generic) += 0.04f;
                    }
                    else
                    {
                        player.statDefense += 2;
                    }
                    if (player.wings > 0)
                    {
                        player.wingTimeMax = (int)(player.wingTimeMax * 1.05f);
                    }
                    return;
                case 299: // Pumpking
                    if (Main.pumpkinMoon)
                    {
                        player.statDefense += 3;
                        player.GetKnockback(DamageClass.Generic) += 0.3f;
                    }
                    player.buffImmune[BuffID.CursedInferno] = true;
                    player.buffImmune[BuffID.Ichor] = true;
                    return;
                // End Master Mode //
                default:
                    return;
            }
        }
    }
}