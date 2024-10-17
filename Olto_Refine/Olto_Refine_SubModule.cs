using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
//using TaleWorlds.ObjectSystem;

namespace Olto_Refine
{
    public class Olto_Refine_SubModule : MBSubModuleBase
    {
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);
            gameStarterObject.AddModel((GameModel)new OltoSmithingModel());
        }
    }

    internal class OltoSmithingModel : DefaultSmithingModel
    {
        public override IEnumerable<Crafting.RefiningFormula> GetRefiningFormulas(Hero weaponsmith)
        {
            yield return new Crafting.RefiningFormula(CraftingMaterials.Wood, 2, CraftingMaterials.Iron1, 0, CraftingMaterials.Charcoal, 3);
            yield return new Crafting.RefiningFormula(CraftingMaterials.IronOre, 1, CraftingMaterials.Charcoal, 1, CraftingMaterials.Iron1, 3);
            yield return new Crafting.RefiningFormula(CraftingMaterials.Iron1, 1, CraftingMaterials.Charcoal, 1, CraftingMaterials.Iron2);
            yield return new Crafting.RefiningFormula(CraftingMaterials.Iron2, 2, CraftingMaterials.Charcoal, 1, CraftingMaterials.Iron3, 1, CraftingMaterials.Iron1, 1);
            // 4 // 50-100 SteelMaker or SteelMaker3 or ExperiencedSmith
            if (weaponsmith.GetPerkValue(DefaultPerks.Crafting.SteelMaker) || weaponsmith.GetPerkValue(DefaultPerks.Crafting.ExperiencedSmith) || weaponsmith.GetPerkValue(DefaultPerks.Crafting.SteelMaker3))
                yield return new Crafting.RefiningFormula(CraftingMaterials.Iron3, 2, CraftingMaterials.Charcoal, 1, CraftingMaterials.Iron4, 1, CraftingMaterials.Iron1, 1);
            else
                yield return new Crafting.RefiningFormula(CraftingMaterials.Iron3, 3, CraftingMaterials.Charcoal, 1, CraftingMaterials.Iron4, 1, CraftingMaterials.Iron1, 2);
            // 5 // 75-150 StrongSmith or VigorousSmith or SteelMaker2 // 50-100 SteelMaker or SteelMaker3 or ExperiencedSmith
            if (weaponsmith.GetPerkValue(DefaultPerks.Crafting.SteelMaker2) || weaponsmith.GetPerkValue(DefaultPerks.Crafting.StrongSmith) || weaponsmith.GetPerkValue(DefaultPerks.Crafting.VigorousSmith))
                yield return new Crafting.RefiningFormula(CraftingMaterials.Iron4, 2, CraftingMaterials.Charcoal, 1, CraftingMaterials.Iron5, 1, CraftingMaterials.Iron1, 1);
            else if (weaponsmith.GetPerkValue(DefaultPerks.Crafting.ExperiencedSmith) || weaponsmith.GetPerkValue(DefaultPerks.Crafting.SteelMaker3) || weaponsmith.GetPerkValue(DefaultPerks.Crafting.SteelMaker))// || weaponsmith.GetPerkValue(DefaultPerks.Crafting.IronMaker))// || weaponsmith.GetPerkValue(DefaultPerks.Crafting.PracticalRefiner) || weaponsmith.GetPerkValue(DefaultPerks.Crafting.PracticalSmelter))
                yield return new Crafting.RefiningFormula(CraftingMaterials.Iron4, 3, CraftingMaterials.Charcoal, 1, CraftingMaterials.Iron5, 1, CraftingMaterials.Iron1, 2);
            else
                yield return new Crafting.RefiningFormula(CraftingMaterials.Iron4, 4, CraftingMaterials.Charcoal, 1, CraftingMaterials.Iron5, 1, CraftingMaterials.Iron1, 3);
            // 6 // 100-200 SteelMaker3 or MasterSmith // 75-150 StrongSmith or VigorousSmith or SteelMaker2 // 50-100 ExperiencedSmith or SteelMaker
            if (weaponsmith.GetPerkValue(DefaultPerks.Crafting.SteelMaker3) || weaponsmith.GetPerkValue(DefaultPerks.Crafting.MasterSmith))
                yield return new Crafting.RefiningFormula(CraftingMaterials.Iron5, 2, CraftingMaterials.Charcoal, 1, CraftingMaterials.Iron6, 1, CraftingMaterials.Iron1, 1);
            else if (weaponsmith.GetPerkValue(DefaultPerks.Crafting.StrongSmith) || weaponsmith.GetPerkValue(DefaultPerks.Crafting.VigorousSmith) || weaponsmith.GetPerkValue(DefaultPerks.Crafting.SteelMaker2))
                yield return new Crafting.RefiningFormula(CraftingMaterials.Iron5, 3, CraftingMaterials.Charcoal, 1, CraftingMaterials.Iron6, 1, CraftingMaterials.Iron1, 2);
            else if (weaponsmith.GetPerkValue(DefaultPerks.Crafting.ExperiencedSmith) || weaponsmith.GetPerkValue(DefaultPerks.Crafting.SteelMaker))
                yield return new Crafting.RefiningFormula(CraftingMaterials.Iron5, 4, CraftingMaterials.Charcoal, 1, CraftingMaterials.Iron6, 1, CraftingMaterials.Iron1, 3);
            else    // (no) 175 ArtisanSmith or PracticalSmith // (no) 125 PracticalRefiner or PracticalSmelter
                yield return new Crafting.RefiningFormula(CraftingMaterials.Iron5, 5, CraftingMaterials.Charcoal, 1, CraftingMaterials.Iron6, 1, CraftingMaterials.Iron1, 4);
        }
    }
}
