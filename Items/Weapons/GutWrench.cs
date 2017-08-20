using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Weapons
{
	public class GutWrench : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gut Wrench");
			Tooltip.SetDefault("The feeling is familiar");
		}
		public override void SetDefaults()
		{
			item.damage = 92;
			item.melee = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 16;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.value = Item.sellPrice(0, 7, 20, 0);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("TornSkin"), 250);
            recipe.AddIngredient(mod.ItemType("SoulofSmite"), 40);
            recipe.AddIngredient(ItemID.CrimtaneBar, 30);
			recipe.AddIngredient(mod.ItemType("StainedBlade"));
            recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
