using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardingUS2._0.Models
{
    public class Home
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int Cars { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string? IdUser { get; set; }
        
        [ForeignKey("IdUser")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        


        //status of the user
        public byte Status { get; set; }

        //date when the user has been created
        public DateTime StartDate { get; set; }

        //date if the user has benn modified
        public DateTime ModificationDate { get; set; }
    }
}
