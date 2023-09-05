using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EquipPerks.Content
{
	public class ResonateStone : ModItem
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
                perksPlayer.recievePetPerks = !perksPlayer.recievePetPerks;
				if (perksPlayer.recievePetPerks)
				{
                    CombatText.NewText(player.Hitbox, Color.LightGreen, Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Toggles.PetOn"));
                }
                else
                {
                    CombatText.NewText(player.Hitbox, Color.LightPink, Language.GetTextValue("Mods.EquipPerks.CommonItemtooltip.Toggles.PetOff"));
                }
                return true;
			}
			return null;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.StoneBlock, 5)
				.AddIngredient(ItemID.Glass, 3)
				.AddIngredient(ItemID.FallenStar, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}