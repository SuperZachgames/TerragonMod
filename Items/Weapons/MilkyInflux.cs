using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;                      //this are the references that we are going to use
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Weapons
{
	public class MilkyInflux : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Milky Influx");
            Tooltip.SetDefault("You dont how you can hold it");
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type != ProjectileID.MoonlordArrow);
            {
                type =  ProjectileID.MoonlordArrow; 
            }
            return true;
		}
		public override void SetDefaults()
		{
			item.damage = 265;
			item.ranged = true;
			item.width = 20;
			item.height = 25;
			item.useTime = 6;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = Item.sellPrice(0, 20, 20, 0);
			item.rare = 11;
			item.UseSound = SoundID.Item39;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the bows in the vanilla source have this
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Arrow;			
            //editors note: cringy mistakes were here
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddIngredient(ItemID.LunarBar, 30);
			recipe.AddIngredient(null, "MoonBar", 20);
			recipe.AddIngredient(null, "AdromedaBar", 10);
            recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

    }
}
