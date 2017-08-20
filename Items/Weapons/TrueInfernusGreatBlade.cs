using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;                    
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Weapons
{
	public class TrueInfernusGreatBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Infernus Greatblade");
			Tooltip.SetDefault("So hot it melted the handle off");
		}
		public override void SetDefaults()
        {
            item.damage = 326;
            item.melee = true;
            item.width = 86;
            item.height = 86;
            item.useTime = 15;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = 10000;
            item.rare = 10;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shootSpeed = 8;
			item.shoot = mod.ProjectileType ("InfernusBlast");
        }
		public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(3) == 0)
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("InfernusDust"));
                //Emit dusts when swing the sword
            }
        }
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 4 + Main.rand.Next(2); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				// float scale = 1f - (Main.rand.NextFloat() * .3f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; // return false because we don't want tmodloader to shoot projectile
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ConcentratedDarkness"), 10);
			recipe.AddIngredient(mod.ItemType("DarkenedFragment"), 20);
			//recipe.AddIngredient(mod.ItemType("ConcentratedBrightness"), 10);
			//recipe.AddIngredient(mod.ItemType("LightenedFragment"), 20);
			recipe.AddIngredient(mod.ItemType("MagmaSword"), 1);
			recipe.AddIngredient(mod.ItemType("AdromedaBar"), 10);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddIngredient(ItemID.FragmentSolar, 25);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}