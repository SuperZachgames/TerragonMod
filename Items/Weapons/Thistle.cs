using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;                      //this are the references that we are going to use
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Weapons
{
	public class Thistle : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("The Thistle");
            Tooltip.SetDefault("I think bugs live in my bow..");
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type != ProjectileID.VenomArrow);
            {
                type =  ProjectileID.VenomArrow; 
            }
            return true;
		}
		public override void SetDefaults()
		{
			item.damage = 25;
			item.ranged = true;
			item.width = 20;
			item.height = 25;
			item.useTime = 25;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 3;
			item.value = Item.sellPrice(0, 5, 20, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the bows in the vanilla source have this
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Arrow;
			item.reuseDelay = 14;
            //editors note: cringy mistakes were here
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Vine, 4);
            recipe.AddIngredient(ItemID.JungleSpores, 8);
            recipe.AddIngredient(ItemID.Stinger, 15);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool ConsumeAmmo(Player player)
		{
			// Because of how the game works, player.itemAnimation will be 11, 7, and finally 3. (UseAmination - 1, then - useTime until less than 0.) 
			// We can get the Clockwork Assult Riffle Effect by not consuming ammo when itemAnimation is lower than the first shot.
			return !(player.itemAnimation < item.useAnimation - 2);
		}
    }
}
