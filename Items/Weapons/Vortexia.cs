using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Weapons
{
	public class Vortexia : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vortexia");
			Tooltip.SetDefault("Blue Fire consumes thy enemy");
		}
		public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("AdromedaSpear");
			item.shootSpeed = 10f;
			item.damage = 342;
			item.knockBack = 6f;
			item.thrown = true;
			item.useStyle = 1;
			item.UseSound = SoundID.Item1;
			item.useAnimation = 25;
			item.useTime = 25;
			item.width = 30;
			item.height = 30;
			item.noUseGraphic = true;
			item.autoReuse = true;
			item.value = Item.sellPrice(0, 5, 5, 0);
			item.rare = 11;
			item.noMelee = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DayBreak, 1);
			recipe.AddIngredient(ItemID.FragmentVortex, 15);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddIngredient(mod.ItemType("AdromedaBar"), 20);
			recipe.AddIngredient(mod.ItemType("MoonBar"), 40);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
