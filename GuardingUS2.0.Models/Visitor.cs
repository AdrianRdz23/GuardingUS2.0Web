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
    public class Visitor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CarPlate { get; set; }
        [Required]
        public DateTime Entrance { get; set; }

        public DateTime Exit { get; set; }

        public string Identification { get; set; }

        [Required]
        public int HomeId { get; set; }
        [ForeignKey("HomeId")]
        [ValidateNever]
        public Home Home { get; set; }

        public string Description { get; set; }


        //status of the user
        public bool Status { get; set; }

        //date when the user has been created
        public DateTime StartDate { get; set; }

        //date if the user has benn modified
        public DateTime ModificationDate { get; set; }
    }
}
