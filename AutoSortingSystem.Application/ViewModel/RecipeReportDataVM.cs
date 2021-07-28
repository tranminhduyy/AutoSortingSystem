using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSortingSystem.Application.ViewModel
{
    public class RecipeReportDataVM
    {
        public int ID { get; set; }
        public string Recipe { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StopTime { get; set; }
        public int? Total { get; set; }
        public int? Gate1Total { get; set; }
        public int? Gate2Total { get; set; }
        public int? Gate3Total { get; set; }
        public int? Gate4Total { get; set; }
        public int? Gate5Total { get; set; }
        public int? Reject { get; set; }
    }
}
