using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerragonMod.Items.Weapons
{
    public class Aliba : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aliba");
            Tooltip.SetDefault("Alis Ultimate Sword");
        }

        public bool projOnSwing = true;

        public override void SetDefaults()
        {
            item.damage = 123;
            item.melee = true;
            item.width = 64;
            item.height = 64;
            item.useTime = 12;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shootSpeed = 8;
			item.shoot = mod.ProjectileType ("AlibaProjectile");
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(3) == 0)
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Ali"));
                //Emit dusts when swing the sword
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 14);
            recipe.AddIngredient(mod.ItemType("MoonBar"), 7);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
