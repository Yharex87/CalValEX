using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CalValEX.Items.Tiles;
using CalValEX.Items.Tiles.FurnitureSets.Auric;

namespace CalValEX.Items.Tiles.FurnitureSets.Auric
{
	public class AuricBrick : ModItem
	{
		public override void SetStaticDefaults() {
		}

		public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
            item.rare = 0;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createTile = ModContent.TileType<AuricBrickPlaced>();
		}

		public override void AddRecipes() {
			Mod CalValEX = ModLoader.GetMod("CalamityMod");
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient((ItemID.StoneBlock));
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("AuricOre"), 1);
				recipe.AddTile(ModLoader.GetMod("CalamityMod").TileType("DraedonsForge"));
				recipe.SetResult(this);
				recipe.AddRecipe();
        }
	}
}