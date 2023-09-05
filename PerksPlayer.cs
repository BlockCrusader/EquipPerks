using Terraria;
using Terraria.ModLoader;

namespace EquipPerks
{
	public class PerksPlayer : ModPlayer
	{
        // Individual, per-player toggles for pet, light pet, and minecart perks
        public bool recievePetPerks = ModContent.GetInstance<PerksConfig>().perkDefault;
        public bool recieveLightPerks = ModContent.GetInstance<PerksConfig>().perkDefault;
        public bool recieveMinecartPerks = ModContent.GetInstance<PerksConfig>().perkDefault;
        public bool recieveWingPerks = ModContent.GetInstance<PerksConfig>().perkDefault;

        // A few perk effects must be manged by this class as well. These variables track said effects
        public bool blackCat; // -0.05 luck, but increase magic crit if negative luck is incurred
        public float perkLuck; // Alternative to equipmentBasedLuckBonus that doesn't give luck to other players

        public override void Unload()
        {
            recievePetPerks = false;
            recieveLightPerks = false;
            recieveMinecartPerks = false;
            recieveWingPerks = false;
        }

        public override void ResetEffects()
        {
            perkLuck = 0f;
            blackCat = false;
        }

        public override void PostUpdateEquips()
        {
            if (blackCat && Player.luck < 0)
            {
                Player.GetCritChance(DamageClass.Magic) += 4f;
            }
        }

        public override void ModifyLuck(ref float luck)
        {
            luck += perkLuck;
            if (blackCat)
            {
                luck -= 0.05f;
            }
        }
    }
}