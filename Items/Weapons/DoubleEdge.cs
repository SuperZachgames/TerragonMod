using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Weapons
{
	public class DoubleEdge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Double Edge");
			Tooltip.SetDefault("This sword has two swords!");
		}
		public override void SetDefaults()
		{
			item.damage = 63;
			item.melee = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("OsmiumBar"), 10);
			recipe.AddIngredient(ItemID.DemoniteBar, 20);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.IronBar, 2);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
