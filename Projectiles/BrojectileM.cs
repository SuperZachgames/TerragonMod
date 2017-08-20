using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Projectiles   //The directory for your .cs and .png; Example: TutorialMOD/Projectiles
{
    public class BrojectileM : ModProjectile   //make sure the sprite file is named like the class name (CustomYoyoProjectile)
    {
		public override void SetStaticDefaults()
		{
			ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 16f;
			ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 400f;
			ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 17.5f;
            DisplayName.SetDefault("BrojectileM");
        }
        public override void SetDefaults()
        {
            projectile.extraUpdates = 0;
            projectile.width = 15;//Set the projectile hitbox width
            projectile.height = 15; //Set the projectile hitbox height            
            projectile.aiStyle = 99; // aiStyle 99 is used for all yoyos, and is Extremely suggested, as yoyo are extremely difficult without them
            projectile.friendly = true;  //Tells the game whether it is friendly to players/friendly npcs or not
            projectile.penetrate = -1; //Tells the game how many enemies it can hit before being destroyed. -1 = never
            projectile.melee = true; //Tells the game whether it is a melee projectile or not        
        }
    }
}