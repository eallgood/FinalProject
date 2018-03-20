using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Data.Entities
{
    public class Vet
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(32)]
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public ICollection<Pet> Patients { get; set; }
    }
}