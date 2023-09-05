using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EquipPerks.Content
{
	public class MinersStone : ModItem
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
			Item.rare = ItemRarityID.Blue;
		}

		public override bool? UseItem(Player player)
		{
			if (player.whoAmI == Main.myPlayer)
			{
                player.TryGetModPlayer(out PerksPlayer perksPlayer);
                perksPlayer.recieveMinecartPerks = !perksPlayer.recieveMinecartPerks;
				if (perksPlayer.recieveMinecartPerks)
				{
                    CombatText.NewText(player.Hitbox, Color.LightGreen, Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Toggles.CartOn"));
                }
                else
                {
                    CombatText.NewText(player.Hitbox, Color.LightPink, Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Toggles.CartOff"));
                }
                return true;
			}
			return null;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<ResonateStone>()
				.AddIngredient(ItemID.GoldBar, 3)
				.AddTile(TileID.Anvils)
				.Register();

			CreateRecipe()
				.AddIngredient<ResonateStone>()
				.AddIngredient(ItemID.PlatinumBar, 3)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}