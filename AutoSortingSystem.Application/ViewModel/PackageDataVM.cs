using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSortingSystem.Application.ViewModel
{
    public class PackageDataVM
    {
        public ushort ID { get; set; }
        public string Barcode { get; set; }
        public ushort Gate { get; set; }
        public string Status { get; set; }
        public bool IsCheck { get; set; }
    }
}
