using OnlinePharmacy.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace OnlinePharmacy.Data
{
    public class OnlinePharmacyContext: DbContext
    {
        public OnlinePharmacyContext()
        {
            
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            Database.SetInitializer(new PharmacyDatabaseInitializer());
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<OrderMedicine> OrderMedicine { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<Stock> Stock { get; set; }
    }

    public class PharmacyDatabaseInitializer : DropCreateDatabaseAlways<OnlinePharmacyContext>
    {
        protected override void Seed(OnlinePharmacyContext context)
        {
            new List<Category>
            {
                new Category{CategoryName = "Antibiotics", Description = "Antibiotics Medicines", DateCreated = DateTime.Now},
                new Category{CategoryName = "Orthopaedics", Description = "Orthopaedics Medicines", DateCreated = DateTime.Now},
                new Category{CategoryName = "Surgical", Description = "Surgical Medicines", DateCreated = DateTime.Now},
                new Category{CategoryName = "Syrups", Description = "Syrups Medicines", DateCreated = DateTime.Now}
            }.ForEach(c => context.Category.Add(c));

            base.Seed(context);
        }

    }
}
