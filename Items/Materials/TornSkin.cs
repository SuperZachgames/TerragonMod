using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TerragonMod.Items.Materials
{
    public class TornSkin : ModItem
    {
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Torn Skin");
			Tooltip.SetDefault("Smells like home");
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
	