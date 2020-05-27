using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Global_Intern.Models
{
    public partial class User
    {
        public string UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserHomeCountry { get; set; }
        public string UserCurrentCountry { get; set; }
        public string UserPassword { get; set; }
        public string UserPhone { get; set; }
       
        public string UserGender { get; set; }

    }
}
