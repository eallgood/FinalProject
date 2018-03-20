using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Data.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(32)]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DOB { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}