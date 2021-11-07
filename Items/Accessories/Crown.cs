using System;
using Terraria;
using Terraria.ModLoader;

namespace TestMod.Items.Accessories
{
	public class Crown : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.Tooltip.SetDefault("This is crown.");
		}

		public override void SetDefaults()
		{
			base.item.accessory = true;
			base.item.width = 77;
			base.item.height = 52;
			base.item.defense = 100000;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.lavaImmune = true;
			player.waterWalk = true;
			player.lifeRegen += 1000000;
			player.lifeRegenCount = 1;
			player.lifeRegenTime = 1;
			player.fireWalk = true;
			player.nightVision = true;
			player.moveSpeed = 1.6f;
			player.noFallDmg = true;
			player.noKnockback = true;
			player.statLifeMax2 += 1000000;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000AC77 File Offset: 0x00008E77
		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddTile(412);
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}
	}
}