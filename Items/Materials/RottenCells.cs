using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TerragonMod.Items.Materials
{
    public class RottenCells : ModItem
    {
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotten Cells");
			Tooltip.SetDefault("Tastes like Grandma");
		}
			public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 1;
            item.maxStack = 999;
        }
    }
}
	