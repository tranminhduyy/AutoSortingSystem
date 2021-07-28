using AutoSortingSystem.Application.ViewModel;
using AutoSortingSystem.Data;
using AutoSortingSystem.Data.EF;
using AutoSortingSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSortingSystem.Application.Service
{
    public class RecipeService
    {
        private static RecipeService _ins;
        public static RecipeService Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new RecipeService();
                return _ins;
            }
            set
            {
                _ins = value;
            }
        }
        public IEnumerable<GateRecipeVM> GetGateRecipe(string recipeID)
        {
            try
            {
                var result = DataProvider.Ins.DB.GateRecipes.Where(y => y.Recipe_ID == recipeID)
                .Select(x => new GateRecipeVM()
                {
                    ID = x.ID,
                    GateNo = x.GateNo,
                    ReferenceCode = x.ReferenceCode
                }).ToList();
                return result;
            }
            catch
            {
                return null;
            }           
        }

        public bool AddRecipeID(string recipeID)
        {
            try
            {
                var recipe = new RecipeManagement()
                {
                    Wh_ID = 1,
                    Recipe = recipeID,
                    ImportDate = DateTime.Now
                };
                DataProvider.Ins.DB.RecipeManagements.Add(recipe);
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddGateRecipe(GateRecipe gateRecipe)
        {
            try
            {
                DataProvider.Ins.DB.GateRecipes.Add(gateRecipe);
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<RecipeVM> GetRecipe(string word)
        {
            try
            {
                var result = DataProvider.Ins.DB.RecipeManagements.
                Select(x => new RecipeVM()
                {
                    ID = x.ID,
                    RecipeCode = x.Recipe,
                    ImportDate = x.ImportDate,
                }).
                Where(y => y.RecipeCode.Contains(word)).
                ToList();
                return result;
            }
            catch
            {
                return null;
            }
        }

        public void FinishRecipe(ProductionRecordVM p)
        {
            var data = new ReportBarcode()
            {
                Wh_ID = 1,
                Recipe = p.Recipe,
                StartTime = p.StartTime,
                StopTime = p.StopTime,
                Total = p.Total,
                Gate1Total = p.Gate1Total,
                Gate2Total = p.Gate2Total,
                Gate3Total = p.Gate3Total,
                Gate4Total = p.Gate4Total,
                Gate5Total = p.Gate5Total,
                Reject = p.Reject,
            };
            DataProvider.Ins.DB.ReportBarcodes.Add(data);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
