using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Materials
{
    public class AdromedaOre : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Adromeda Ore");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 100;
            item.rare = 5;
            item.maxStack = 999;
        }
    }
}