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
    public class ReportService
    {
        private static ReportService _ins;
        public static ReportService Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new ReportService();
                return _ins;
            }
            set
            {
                _ins = value;
            }
        }
        public IEnumerable<ReportBarcodeListVM> GetReportBarcodeList(DateTime from, DateTime to, string recipeID)
        {
            try
            {
                var res = DataProvider.Ins.DB.ReportBarcodes
                .Where(x => x.StartTime >= from && x.StopTime <= to && x.Recipe.Contains(recipeID))
                .Select(x => new ReportBarcodeListVM()
                {
                    ID = x.ID,
                    Recipe = x.Recipe,
                    StartTime = x.StartTime,
                    StopTime = x.StopTime,
                }).ToList();
                return res;
            }
            catch
            {
                return null;
            }
            
        }

        public RecipeReportDataVM GetRecipeReportInfo(string id)
        {
            try
            {
                var res = DataProvider.Ins.DB.ReportBarcodes
                .Where(x => x.ID.ToString() == id)
                .Select(y => new RecipeReportDataVM()
                {
                    ID = y.ID,
                    Recipe = y.Recipe,
                    StartTime = y.StartTime,
                    StopTime = y.StopTime,
                    Total = y.Total,
                    Gate1Total = y.Gate1Total,
                    Gate2Total = y.Gate2Total,
                    Gate3Total = y.Gate3Total,
                    Gate4Total = y.Gate4Total,
                    Gate5Total = y.Gate5Total,
                    Reject = y.Reject,
                }).SingleOrDefault();
                return res;
            }
            catch
            {
                return null;
            }           
        }
    }
}
