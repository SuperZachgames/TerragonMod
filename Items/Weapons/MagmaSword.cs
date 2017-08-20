using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;                    
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Weapons
{
	public class MagmaSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Inferno");
			Tooltip.SetDefault("Its so hot you can barely hold it");
		}
		public override void SetDefaults()
		{
			item.damage = 65;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 12;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LivingFireBlock, 45);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddIngredient(mod.ItemType("SoulofSmite"), 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(3) == 0)
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("InfrenusDust"));
                //Emit dusts when swing the sword
            }
        }
	}
}
