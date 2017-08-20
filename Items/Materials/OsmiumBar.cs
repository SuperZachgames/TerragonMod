using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Materials
{
    public class OsmiumBar : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Osmium Bar");
            Tooltip.SetDefault("Isnt this just obsidian?");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 4;
            item.maxStack = 999;
        }
    }
}