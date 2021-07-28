using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSortingSystem.Application.ViewModel
{
    public class UserListVM
    {
        public Guid ID { get; set; }
        public string UserName { get; set; }
        public bool Activate { get; set; }
        public string Role { get; set; }
    }
}
