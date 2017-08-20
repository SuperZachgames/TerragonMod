using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Materials
{
    public class MoonBar : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moon Bar");
            Tooltip.SetDefault("Its been places you cant imagine");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 5;
            item.maxStack = 999;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MoonRocks", 4);
            recipe.AddTile(TileID.LunarCraftingStation);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}