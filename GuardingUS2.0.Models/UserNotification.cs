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
    public class UserNotification
    {
        [Key]
        public int IdNotification { get; set; }

        //Create a Notification Model
        [ForeignKey("IdNotification")]
        [ValidateNever]
        public Notification Notification { get; set; }

        [Required]
        public string IdUser { get; set; }

        //Create a visitor Model
        [ForeignKey("IdUser")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }

        public byte Status { get; set; }

        //date when the user has been created
        public DateTime StartDate { get; set; }

        //date if the user has benn modified
        public DateTime ModificationDate { get; set; }
    }
}
