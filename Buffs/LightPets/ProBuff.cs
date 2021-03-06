using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Buffs.LightPets
{
    public class  ProBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("The Profaned Armada");
            Description.SetDefault("Providence and her army shines holy light through the dark.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.lightPet[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<CalValEXPlayer>().ProGuard1 = true;
            player.GetModPlayer<CalValEXPlayer>().ProGuard2 = true;
            player.GetModPlayer<CalValEXPlayer>().ProGuard3 = true;
            player.GetModPlayer<CalValEXPlayer>().ProviPet = true;
            bool petProjectileNotSpawned = (player.ownedProjectileCounts[mod.ProjectileType("ProGuard1")] <= 0 &&
                                            player.ownedProjectileCounts[mod.ProjectileType("ProGuard2")] <= 0 &&
                                            player.ownedProjectileCounts[mod.ProjectileType("ProGuard3")] <= 0 &&
                                            player.ownedProjectileCounts[mod.ProjectileType("ProviPet")] <= 0
                                           ); 
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("ProGuard1"), 0, 0f, player.whoAmI, 0f, 0f);
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("ProGuard2"), 0, 0f, player.whoAmI, 0f, 0f);
                 Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("ProGuard3"), 0, 0f, player.whoAmI, 0f, 0f);
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("ProviPet"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }

}