using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSortingSystem.Application.ViewModel
{
    public class UserInfoVM
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public bool Active { get; set; }
        public string Role { get; set; }
    }
}
