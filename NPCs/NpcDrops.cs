using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TerragonMod.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
 
		    if (npc.type == NPCID.Lihzahrd)   
            {
                if (Main.rand.Next(999) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BroYoM"), 1);
                         //Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BroYoL"), 1);
                    }
                }
            }
			if (npc.type == NPCID.LihzahrdCrawler)  
            {
                if (Main.rand.Next(999) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BroYoM"), 1);
                         //Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BroYoL"), 1);
                    }
                }
            }
			if (npc.type == NPCID.FlyingSnake)   
            {
                if (Main.rand.Next(999) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BroYoM"), 1);
                         //Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BroYoL"), 1);
                    }
                }
            }
			if (!Main.hardMode) //Hardmode items go here
			{
				if (Main.bloodMoon) 
				{
					if (Main.rand.Next(1) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SoulofSmite"), 1);
					}
				}
			}
            if (npc.type == NPCID.MoonLordCore)   //this is where you choose the npc you want
            {
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AdromedaOre"), 60);
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MoonRocks"), 80);
                    }
                }
            }
            {
                if (Main.player[Main.myPlayer].ZoneCorrupt)          //this is where you choose what biome you whant the item to drop. ZoneCorrupt is in Corruption
                {
                    if (Main.rand.Next(0) == 0)
                    {
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RottenCells"), 1); 
                    } 
                } 
				if (Main.player[Main.myPlayer].ZoneCrimson)          //this is where you choose what biome you whant the item to drop. ZoneCorrupt is in Corruption
                {
                    if (Main.rand.Next(0) == 0)
                    {
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TornSkin"), 1); 
                    } 
                }
			}       
        }
    }
}