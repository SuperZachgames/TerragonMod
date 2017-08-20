using Terraria.ModLoader;

namespace TerragonMod
{
	class TerragonMod : Mod
	{
		public TerragonMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
