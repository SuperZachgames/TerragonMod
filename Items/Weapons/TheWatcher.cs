using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Weapons
{
	public class TheWatcher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Watcher");
			Tooltip.SetDefault("It watches you no matter what, like a friend");
		}
		public override void SetDefaults()
		{
			item.damage = 35;
			item.melee = true;
			item.width = 60;
			item.height = 64;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("RottenCells"), 200);
            recipe.AddIngredient(mod.ItemType("SoulofSmite"), 10);
            recipe.AddIngredient(ItemID.DemoniteBar, 25);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
