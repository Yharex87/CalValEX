using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Tiles.Paintings
{
    public class RogueExtractor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rogue Extractor");
            Tooltip.SetDefault("'Mathew Maple'\n");
        }

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.maxStack = 99;
            item.consumable = true;
            item.createTile = ModContent.TileType<RogueExtractorPlaced>();
            item.width = 12;
            item.height = 12;
            item.rare = ItemRarityID.Yellow;
        }
    }
}