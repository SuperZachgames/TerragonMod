using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;                      //this are the references that we are going to use
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Weapons
{
	public class MoltenWartone : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Molten Wartone");
            Tooltip.SetDefault("Its arrows fly at the speed of War");
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type != ProjectileID.HellfireArrow);
            {
                type =  ProjectileID.HellfireArrow; 
            }
            return true;
		}		
		public override void SetDefaults()
		{
			item.damage = 84;
			item.ranged = true;
			item.width = 20;
			item.height = 25;
			item.useTime = 4;
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
			recipe.AddIngredient(ItemID.MoltenFury, 1);
            recipe.AddIngredient(null, "SoulofSmite", 30);
			recipe.AddIngredient(ItemID.HellstoneBar, 20);
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
            recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Poisoned, 60);      //Add Onfire buff to the NPC for 1 second
		}
		public override bool ConsumeAmmo(Player player)
		{
			// Because of how the game works, player.itemAnimation will be 11, 7, and finally 3. (UseAmination - 1, then - useTime until less than 0.) 
			// We can get the Clockwork Assult Riffle Effect by not consuming ammo when itemAnimation is lower than the first shot.
			return !(player.itemAnimation < item.useAnimation - 2);
		}
    }
}