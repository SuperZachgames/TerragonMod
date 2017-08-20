using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Weapons
{
	public class StainedBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stained Blade");
			Tooltip.SetDefault("The blood is familiar");
		}
		public override void SetDefaults()
		{
			item.damage = 39;
			item.melee = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("TornSkin"), 200);
            recipe.AddIngredient(mod.ItemType("SoulofSmite"), 10);
            recipe.AddIngredient(ItemID.CrimtaneBar, 25);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
