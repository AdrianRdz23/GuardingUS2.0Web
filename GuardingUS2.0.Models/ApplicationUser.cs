using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardingUS2._0.Models
{
    public class ApplicationUser : IdentityUser
    {
        //name of the user
        [Required]
        [StringLength(50, MinimumLength = 1)]
        [DisplayName("Name needs to be typed correctly")]
        public string Name { get; set; }
        //[Required]
        //public int IdRole { get; set; }
        //[ForeignKey("IdRole")]
        //[ValidateNever]
        //public Role Role { get; set; }

        //status of the user
        public byte Status { get; set; }

        //date when the user has been created
        public DateTime StartDate { get; set; }

        //date if the user has benn modified
        public DateTime ModificationDate { get; set; }
    }
}
