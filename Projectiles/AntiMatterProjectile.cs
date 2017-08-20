using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Projectiles
{
    public class AntiMatterProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("AMP");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Bullet);
			aiType = ProjectileID.Bullet;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.timeLeft = 120;
			projectile.damage = 309;
			ProjectileID.Sets.Homing[projectile.type] = true;
        }
        public override void DrawBehind(int index, List<int> drawCacheProjsBehindNPCsAndTiles, List<int> drawCacheProjsBehindNPCs, List<int> drawCacheProjsBehindProjectiles, List<int> drawCacheProjsOverWiresUI)
        {
            drawCacheProjsBehindNPCsAndTiles.Add(index);
        }

        public override void AI()
		{
            if (Main.rand.Next(3) == 0)
			{
                Dust dust = Main.dust[Dust.NewDust(projectile.position, 20, 20, mod.DustType("DarkDust"), 0.0f, 0.0f, 100, new Color(), 1.5f)];
            }
        }
    }
}