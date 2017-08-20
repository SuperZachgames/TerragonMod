using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace TerragonMod.NPCs
{
	[AutoloadHead]
	public class AncientCultistTownNPC : ModNPC
	{
		public override string Texture
		{
			get
			{
				return "TerragonMod/NPCs/AncientCultistTownNPC";
			}
		}

		public override bool Autoload(ref string name)
		{
			name = "Ancient Cultist";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Cultist");
			Main.npcFrameCount[npc.type] = 23;
			NPCID.Sets.ExtraFramesCount[npc.type] = 7;
			NPCID.Sets.AttackFrameCount[npc.type] = 2;
			NPCID.Sets.DangerDetectRange[npc.type] = 900;
			NPCID.Sets.AttackType[npc.type] = 2;
			NPCID.Sets.AttackTime[npc.type] = 10;
			NPCID.Sets.AttackAverageChance[npc.type] = 10;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 100;
			npc.defense = 200;
			npc.lifeMax = 666;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			aiType = NPCID.Wizard;
			animationType = NPCID.Wizard;
		}
		public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            return (NPC.downedBoss3);  //so after Skeletron has been killed
            {
                return true;
            }
        }
		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(6))
			 {
                case 0:
                    return "Charles";
                case 1:
                    return "Zach";
                case 2:
                    return "Ramus";
                case 3:
                    return "Asahara";
                case 4:
                    return "Blue Magic";
                case 5:
                    return "Nug";
                default:
                    return "Ren";
            }
		}

		public override void FindFrame(int frameHeight)
		{
			/*npc.frame.Width = 23;
			if (((int)Main.time / 10) % 2 == 0)
			{
				npc.frame.X = 40;
			}
			else
			{
				npc.frame.X = 0;
			}*/
		}

		public override string GetChat()
		{
            int guideNPC = NPC.FindFirstNPC(NPCID.Guide); //this make so when this npc is close to the Guide
            if (guideNPC >= 0 && Main.rand.Next(4) == 0) //has 1 in 3 chance to show this message
            {
                return "Sure you can ask the guide for advice, but if you enjoy your life you wouldnt speak to him...";
            }
            switch (Main.rand.Next(7))    //this are the messages when you talk to the npc
			{
				case 0:
                    return "Woah! Oh, you want to buy my stuff? Huh, suprised you talked to me is all...";
                case 1:
                    return "What are you talking to me for?";
                case 2:
                    return "I like your place, wish it had a basement though...";
                case 3:
                    return "Im Blue dadadadada... OH HELLO THERE.";
				case 4:
					return "Are my eyes even real? Oh, oops. Talking to myself again...";
				case 5:
					return "That Wizard is just copying me... if you find him and bring him here...";
				case 6:
					return "Where can a Cultist find a bathroom round here?";
                default:
                    return "Have you seen any of my brothers? Will you murder them for me? Thanks...";
			}
		}

		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Lang.inter[28].Value;
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
            if (NPC.downedBoss3)   //this make so when Skeletron is killed the town npc will sell this
            {
                shop.item[nextSlot].SetDefaults(ItemID.GuideVoodooDoll);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.ClothierVoodooDoll);
                if (NPC.downedMechBossAny)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalEye);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalSkull);
                    nextSlot++;
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalWorm);

                    if (NPC.downedMoonlord)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.FragmentSolar);
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemID.FragmentVortex);
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemID.FragmentStardust);
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemID.FragmentNebula);
                    }
                }
			}
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 500;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 10;
			randExtraCooldown = 15;
		}

	}
}