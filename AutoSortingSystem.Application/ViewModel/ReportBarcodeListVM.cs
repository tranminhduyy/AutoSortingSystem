using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSortingSystem.Application.ViewModel
{
    public class ReportBarcodeListVM
    {
        public int ID { get; set; }
        public string Recipe { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StopTime { get; set; }
    }
}
