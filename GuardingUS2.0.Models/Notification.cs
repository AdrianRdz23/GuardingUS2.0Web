using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuardingUS2._0.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public string IdUser { get; set; }


        [ForeignKey("IdUser")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }


        [Required]
        public string Message { get; set; }

        public bool IsSelected { get; set; }

        //status of the user
        public byte Status { get; set; }

        //date when the user has been created
        public DateTime StartDate { get; set; }

        //date if the user has benn modified
        public DateTime ModificationDate { get; set; }
    }
}