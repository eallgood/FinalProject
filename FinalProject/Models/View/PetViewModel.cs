using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models.View
{
    public class PetViewModel
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        [Display(Name = "Pet's Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Pet's Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Next Checkup")]
        public DateTime NextCheckup { get; set; }

        [Required]
        [Display(Name = "Vet ID")]
        public int VetId { get; set; }
    }
}