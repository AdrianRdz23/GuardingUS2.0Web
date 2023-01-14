using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardingUS2._0.Models.ViewModels
{
    public class HomeVM
    {
        public Home Home { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> UserList { get; set; }

        //public IEnumerable<Home> Home { get; set; }
        //public IEnumerable<ApplicationUser> User { get; set; }


        //public HomeVM()
        //{

        //}

        //public HomeVM(ApplicationUser user, Home home)
        //{
        //    User = user;
        //    Home = home;
        //}
    }
}
