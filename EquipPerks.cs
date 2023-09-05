using System;
using Terraria;
using Terraria.ModLoader;

namespace EquipPerks
{
	public class EquipPerks : Mod
	{
        public override object Call(params object[] args)
        {
            // Make sure the call doesn't include anything that could potentially cause exceptions.
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args), "Arguments cannot be null!");
            }

            if (args.Length == 0)
            {
                throw new ArgumentException("Arguments cannot be empty!");
            }

            if (args[0] is string callName)
            {
                bool check = false;
                switch (callName)
                {
                    case "PerksActivePets": // Returns if the player corresponding to the index of the given int has pet perks on
                        if (args[1] is not int pPlayerID)
                        {
                            throw new Exception($"Expected an argument of type int for player index, but got type {args[1].GetType().Name} instead.");
                        }
                        check = Main.player[pPlayerID].GetModPlayer<PerksPlayer>().recievePetPerks;
                        break;
                    case "PerksActiveLightPets": // Returns if the player corresponding to the index of the given int has light pet perks on
                        if (args[1] is not int lPlayerID)
                        {
                            throw new Exception($"Expected an argument of type int for player index, but got type {args[1].GetType().Name} instead.");
                        }
                        check = Main.player[lPlayerID].GetModPlayer<PerksPlayer>().recievePetPerks;
                        break;
                    case "PerksActiveMinecarts": // Returns if the player corresponding to the index of the given int has minecart perks on
                        if (args[1] is not int mPlayerID)
                        {
                            throw new Exception($"Expected an argument of type int for player index, but got type {args[1].GetType().Name} instead.");
                        }
                        check = Main.player[mPlayerID].GetModPlayer<PerksPlayer>().recievePetPerks;
                        break;
                    case "PerksActiveWings": // Returns if the player corresponding to the index of the given int has wing perks on
                        if (args[1] is not int wPlayerID)
                        {
                            throw new Exception($"Expected an argument of type int for player index, but got type {args[1].GetType().Name} instead.");
                        }
                        check = Main.player[wPlayerID].GetModPlayer<PerksPlayer>().recievePetPerks;
                        break;
                    case "PerkTooltipsPets": // Returns if tooltips for pet perks are enabled in the config
                        check = ModContent.GetInstance<PerksConfig>().petTooltips;
                        break;
                    case "PerkTooltipsLightPets": // Returns if tooltips for lightvpet perks are enabled in the config
                        check = ModContent.GetInstance<PerksConfig>().lightTooltips;
                        break; 
                    case "PerkTooltipsMinecarts": // Returns if tooltips for minecart perks are enabled in the config
                        check = ModContent.GetInstance<PerksConfig>().cartTooltips;
                        break;
                    case "PerkTooltipsWings": // Returns if tooltips for wing perks are enabled in the config
                        check = ModContent.GetInstance<PerksConfig>().wingTooltips;
                        break;
                    default:
                        return false;
                }
                return check;
            }

            return false;
        }
    }
}