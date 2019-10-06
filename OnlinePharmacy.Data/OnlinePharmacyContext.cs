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
        public DbSet<tblCategories> Category { get; set; }
        public DbSet<tblCompany> Company { get; set; }
        public DbSet<tblInventory> Inventory { get; set; }
        public DbSet<tblOrderMedicine> OrderMedicine { get; set; }
        public DbSet<tblPayment> Payment { get; set; }
        public DbSet<tblShoppingCart> ShoppingCart { get; set; }
        public DbSet<tblStock> Stock { get; set; }
    }

    public class PharmacyDatabaseInitializer : DropCreateDatabaseAlways<OnlinePharmacyContext>
    {
        protected override void Seed(OnlinePharmacyContext context)
        {
            new List<tblCategories>
            {
                new tblCategories{CategoryName = "Antibiotics", Description = "Antibiotics Medicines"},
                new tblCategories{CategoryName = "Orthopaedics", Description = "Orthopaedics Medicines"},
                new tblCategories{CategoryName = "Surgical", Description = "Surgical Medicines"},
                new tblCategories{CategoryName = "Syrups", Description = "Syrups Medicines"}
            }.ForEach(c => context.Category.Add(c));

            base.Seed(context);
        }

    }
}
