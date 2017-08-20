using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Projectiles
{
    public class AdromedaSpear : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("AdromedaSpear");
        }

        public override void SetDefaults()
        {
			projectile.CloneDefaults(ProjectileID.Daybreak);
			aiType = ProjectileID.Daybreak;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.timeLeft = 240;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 100;
			projectile.width = 124;
            projectile.height = 30;
			projectile.hide = false;
        }
		
		public override void AI()
		{
            if (Main.rand.Next(3) == 0)
			{
                Dust dust = Main.dust[Dust.NewDust(projectile.position, 20, 20, mod.DustType("VortexDust"), 0.0f, 0.0f, 100, new Color(), 1.5f)];
            }
        }
    }
}