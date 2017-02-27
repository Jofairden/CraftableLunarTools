using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace CraftableLunarTools
{
	// (c) Jofairden
	internal class CraftableLunarTools : Mod
	{
		public CraftableLunarTools()
		{
			
		}

		public override void Load()
		{
			var list = new List<short>(Extensions.LunarTools);
			list.ForEach(x =>
				ItemID.Sets.Deprecated[x] = false);
		}

		public override void AddRecipes()
		{
			Extensions.DestroyRecipes();
			Extensions.MakeSolarRecipes(this);
			Extensions.MakeNebulaRecipes(this);
			Extensions.MakeVortexRecipes(this);
			Extensions.MakeStardustRecipes(this);
		}

	}

	internal static class Extensions
	{
		public static short[] LunarTools =
		{
			ItemID.SolarFlareChainsaw,
			ItemID.SolarFlareAxe,
			ItemID.SolarFlareDrill,
			ItemID.SolarFlareHammer,
			ItemID.NebulaChainsaw,
			ItemID.NebulaAxe,
			ItemID.NebulaDrill,
			ItemID.NebulaHammer,
			ItemID.VortexChainsaw,
			ItemID.VortexAxe,
			ItemID.VortexDrill,
			ItemID.VortexHammer,
			ItemID.StardustChainsaw,
			ItemID.StardustAxe,
			ItemID.StardustDrill,
			ItemID.StardustHammer
		};

		public const short LunarBar = 3467;
		public const short AncientManipulator = 412;

		public static void MakeRecipe(this ModRecipe recipe, short fragmentType, int fragmentAmount, int barAmount)
		{
			recipe.AddIngredient(fragmentType, fragmentAmount);
			recipe.AddIngredient(LunarBar, barAmount);
			recipe.AddTile(AncientManipulator);
		}

		public static void DestroyRecipes()
		{
			foreach (var lunarTool in LunarTools)
			{
				var finder = new RecipeFinder();
				finder.SetResult(lunarTool);
				var recipes = finder.SearchRecipes();
				recipes.ForEach(x =>
				{
					var editor = new RecipeEditor(x);
					editor.DeleteRecipe();
				});
			}
		}

		public static void MakeSolarRecipes(Mod mod)
		{
			// Solar Flare Chainsaw
			var recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentSolar, 12, 10);
			recipe.SetResult(ItemID.SolarFlareChainsaw);
			recipe.AddRecipe();

			// Solar Flare Axe
			recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentSolar, 12, 10);
			recipe.SetResult(ItemID.SolarFlareAxe);
			recipe.AddRecipe();

			// Solar Flare Drill
			recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentSolar, 12, 10);
			recipe.SetResult(ItemID.SolarFlareDrill);
			recipe.AddRecipe();

			// Solar Flare Hammer
			recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentSolar, 12, 10);
			recipe.SetResult(ItemID.SolarFlareHammer);
			recipe.AddRecipe();
		}

		public static void MakeNebulaRecipes(Mod mod)
		{
			// Nebula Chainsaw
			var recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentNebula, 12, 10);
			recipe.SetResult(ItemID.NebulaChainsaw);
			recipe.AddRecipe();

			// Nebula Axe
			recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentNebula, 12, 10);
			recipe.SetResult(ItemID.NebulaAxe);
			recipe.AddRecipe();

			// Nebula Drill
			recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentNebula, 12, 10);
			recipe.SetResult(ItemID.NebulaDrill);
			recipe.AddRecipe();

			// Nebula Hammer
			recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentNebula, 12, 10);
			recipe.SetResult(ItemID.NebulaHammer);
			recipe.AddRecipe();
		}


		public static void MakeVortexRecipes(Mod mod)
		{
			// Vortex Chainsaw
			var recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentVortex, 12, 10);
			recipe.SetResult(ItemID.VortexChainsaw);
			recipe.AddRecipe();

			// Vortex Axe
			recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentVortex, 12, 10);
			recipe.SetResult(ItemID.VortexAxe);
			recipe.AddRecipe();

			// Vortex Drill
			recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentVortex, 12, 10);
			recipe.SetResult(ItemID.VortexDrill);
			recipe.AddRecipe();

			// Vortex Hammer
			recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentVortex, 12, 10);
			recipe.SetResult(ItemID.VortexHammer);
			recipe.AddRecipe();
		}

		public static void MakeStardustRecipes(Mod mod)
		{
			// Stardust Chainsaw
			var recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentStardust, 12, 10);
			recipe.SetResult(ItemID.StardustChainsaw);
			recipe.AddRecipe();

			// Stardust  Axe
			recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentStardust, 12, 10);
			recipe.SetResult(ItemID.StardustAxe);
			recipe.AddRecipe();

			// Stardust Drill
			recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentStardust, 12, 10);
			recipe.SetResult(ItemID.StardustDrill);
			recipe.AddRecipe();

			// Stardust Hammer
			recipe = new ModRecipe(mod);
			recipe.MakeRecipe(ItemID.FragmentStardust, 12, 10);
			recipe.SetResult(ItemID.StardustHammer);
			recipe.AddRecipe();
		}
	}
}
