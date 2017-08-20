using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Materials
{
    public class ConcentratedDarkness : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Concentrated Darkness");
            Tooltip.SetDefault("Extremely Heavy");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 8;
            item.maxStack = 999;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DarkenedFragment", 4);
            recipe.AddTile(TileID.MythrilAnvil);			
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}