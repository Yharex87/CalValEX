﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CalValEX;
using CalValEX.Items;
using CalValEX.Items.Hooks;
using Terraria.DataStructures;
using System;
using System.Collections.Generic;

namespace CalValEX.Items.Pets
{
    public class SandBottle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Sand Pail");
            Tooltip.SetDefault("An elemental's favorite pail!");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.NPCHit5;
            item.shoot = mod.ProjectileType("sandmini");
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 4;
            item.buffType = mod.BuffType("SsandBuff");
        }
        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}
