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


    }
}
