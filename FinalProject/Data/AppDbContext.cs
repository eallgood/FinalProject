using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FinalProject.Data.Entities;

namespace FinalProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new AppDbInitializer());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<Vet> Vets { get; set; }

        public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
        {

        }

        public System.Data.Entity.DbSet<FinalProject.Models.View.PetViewModel> PetViewModels { get; set; }
    }
}