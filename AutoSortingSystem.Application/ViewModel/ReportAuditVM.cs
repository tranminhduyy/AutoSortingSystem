using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSortingSystem.Application.ViewModel
{
    public class ReportAuditVM
    {
        public int ID { get; set; }
        public DateTime? EvTime { get; set; }
        public string EvUser { get; set; }
        public string EvMessage { get; set; }
    }
}
