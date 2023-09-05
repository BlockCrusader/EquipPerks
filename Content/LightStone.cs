using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EquipPerks.Content
{
	public class LightStone : ModItem
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
				perksPlayer.recieveLightPerks = !perksPlayer.recieveLightPerks;
				if (perksPlayer.recieveLightPerks)
				{
                    CombatText.NewText(player.Hitbox, Color.LightGreen, Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Toggles.LightOn"));
                }
                else
                {
                    CombatText.NewText(player.Hitbox, Color.LightPink, Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Toggles.LightOff"));
                }
                return true;
			}
			return null;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<ResonateStone>()
				.AddIngredient(ItemID.FallenStar, 3)
				.AddTile(TileID.Furnaces)
				.Register();
		}
	}
}