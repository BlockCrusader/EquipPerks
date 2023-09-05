using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EquipPerks.Content
{
	public class PotentialStone : ModItem
	{

		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 16;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.UseSound = SoundID.Item25;
			Item.value = Item.buyPrice(0, 0, 30, 0);
			Item.rare = ItemRarityID.Green;
		}

		public override bool? UseItem(Player player)
		{
			if (player.whoAmI == Main.myPlayer)
			{
                player.TryGetModPlayer(out PerksPlayer perksPlayer);
                if (perksPlayer.recievePetPerks 
					&& perksPlayer.recieveLightPerks 
					&& perksPlayer.recieveMinecartPerks 
					&& perksPlayer.recieveWingPerks)
                {
					perksPlayer.recievePetPerks = false;
					perksPlayer.recieveLightPerks = false;
					perksPlayer.recieveMinecartPerks = false;
					perksPlayer.recieveWingPerks = false;
					CombatText.NewText(player.Hitbox, Color.LightPink, Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Toggles.AllOff"));
                }
                else
                {
					perksPlayer.recievePetPerks = true;
					perksPlayer.recieveLightPerks = true;
					perksPlayer.recieveMinecartPerks = true;
					perksPlayer.recieveWingPerks = true;
					CombatText.NewText(player.Hitbox, Color.LightGreen, Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Toggles.AllOn"));
                }
				return true;
			}
			return null;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<ResonateStone>()
				.AddIngredient(ItemID.FallenStar, 1)
				.AddIngredient(ItemID.GoldBar, 1)
				.AddIngredient(ItemID.SoulofFlight, 1)
				.AddTile(TileID.AdamantiteForge)
				.Register();

			CreateRecipe()
				.AddIngredient<ResonateStone>()
				.AddIngredient(ItemID.FallenStar, 1)
				.AddIngredient(ItemID.PlatinumBar, 1)
				.AddIngredient(ItemID.SoulofFlight, 1)
				.AddTile(TileID.AdamantiteForge)
				.Register();
		}
	}
}