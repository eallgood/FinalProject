using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Data.Entities
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime NextCheckup { get; set; }
        public int VetId { get; set; }
        public Vet Vet { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}