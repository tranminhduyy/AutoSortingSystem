using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSortingSystem.Application.ViewModel
{
    public class RecipeVM
    {
        public int ID { get; set; }
        public string RecipeCode { get; set; }
        public DateTime? ImportDate { get; set; }
    }
}
