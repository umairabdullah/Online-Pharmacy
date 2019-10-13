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
        public DbSet<Medicine> Medicine { get; set; }
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
            var categories = new List<Category>
            {
                new Category{CategoryName = "Antibiotics", Description = "Antibiotics Medicines", DateCreated = DateTime.Now},
                new Category{CategoryName = "Orthopaedics", Description = "Orthopaedics Medicines", DateCreated = DateTime.Now},
                new Category{CategoryName = "Surgical", Description = "Surgical Medicines", DateCreated = DateTime.Now},
                new Category{CategoryName = "Syrups", Description = "Syrups Medicines", DateCreated = DateTime.Now}
            };

            categories.ForEach(c => context.Category.Add(c));

            new List<Medicine>
            {
                new Medicine {Category = categories[0],Name="Augmentin", Description="Augmentin is used to treat anti bacterial component that harms the body by infection ", BatchNo="45FF-Aug", Dosage="3 per day", Formula="ES-600", MafBy="Getz", Price=34.34M, MafDate= new DateTime(2018, 5, 5),ExpDate= new DateTime(2022, 4, 21)},
                new Medicine {Category = categories[0],Name="Flagyl", Description="Flagyl is used to treat anti bacterial component that harms the body by infection ", BatchNo="Fly-89", Dosage="1/Day", Formula="Metronidazole", MafBy="Getz Pharma Private Limited", Price=40.00M, MafDate= new DateTime(2018, 9, 4),ExpDate= new DateTime(2022, 4, 21)},
                new Medicine {Category = categories[0],Name="Amoxil", Description="Amoxil is used to treat anti bacterial component that harms the body by infection ", BatchNo="Amox-EF50", Dosage="2", Formula="Metronidazole", MafBy="Getz Pharma Private Limited", Price=75.00M, MafDate= new DateTime(2018, 9, 4),ExpDate= new DateTime(2019, 5, 3)},
                new Medicine {Category = categories[1],Name="Cipro", Description="Cipro is also used to treat people who have been exposed to anthrax or certain types of plague.", BatchNo="CPR-FF3", Dosage="2 times", Formula="ciprofloxacin", MafBy="Abbott", Price=65.00M, MafDate= new DateTime(2017, 1, 1),ExpDate= new DateTime(2019, 1, 5)},
                new Medicine {Category = categories[1],Name="Keflex", Description="Keflex is used to treat infections caused by bacteria", BatchNo="CPR-FF3", Dosage="2 times", Formula="cephalexin", MafBy="Abbott", Price=65.00M, MafDate= new DateTime(2017, 1, 1),ExpDate= new DateTime(2019, 1, 5)},
                new Medicine {Category = categories[1],Name="Bactrim", Description="Bactrim is used to treat ear infections, urinary tract infections", BatchNo="BEC-FF3", Dosage="2 times", Formula=" sulfamethoxazole and trimethoprim", MafBy="Abbott", Price=65.00M, MafDate= new DateTime(2017, 1, 1),ExpDate= new DateTime(2019, 1, 5)},
                new Medicine {Category = categories[2],Name="Levaquin", Description="Levaquin (levofloxacin) is a fluoroquinolone antibiotic that fights bacteria in the body.", BatchNo="BEC-FF3", Dosage="2 times", Formula=" levofloxacin", MafBy="Abbott", Price=65.00M, MafDate= new DateTime(2017, 1, 1),ExpDate= new DateTime(2019, 1, 5)},
                new Medicine {Category = categories[2],Name="Zithromax", Description="Zithromax (azithromycin) is an antibiotic that fights bacteria.", BatchNo="BEC-FF3", Dosage="2 times", Formula="azithromycin (a ZITH roe MYE sin)", MafBy="Abbott", Price=65.00M, MafDate= new DateTime(2017, 1, 1),ExpDate= new DateTime(2019, 1, 5)},
                new Medicine {Category = categories[2],Name="Avelox", Description="Avelox (moxifloxacin) is a fluoroquinolone fantibiotic that fights bacteria in the body.", BatchNo="BEC-FF3", Dosage="2 times", Formula=" moxifloxacin (oral) (moxi FLOX a sin)", MafBy="Abbott", Price=65.00M, MafDate= new DateTime(2017, 1, 1),ExpDate= new DateTime(2019, 1, 5)},
                new Medicine {Category = categories[3],Name="Cleocin", Description="Cleocin is used to treat serious infections caused by bacteria.", BatchNo="BEC-FF3", Dosage="2 times", Formula="clindamycin (klin da MYE sin)", MafBy="Abbott", Price=65.00M, MafDate= new DateTime(2017, 1, 1),ExpDate= new DateTime(2019, 1, 5)},
                new Medicine {Category = categories[3],Name="LAMOTRIGINE 25mg", Description="The risk of nonserious rash may be increased when the recommended initial dose and/or the rate of dose escalation for LAMICTAL is exceeded and in patients with a history of allergy or rash to other AEDs.", BatchNo="BEC-FF3", Dosage="2 times", Formula="triazine anticonvulsants", MafBy="Getz Pharma", Price=65.00M, MafDate= new DateTime(2017, 1, 1),ExpDate= new DateTime(2019, 1, 5)},
                new Medicine {Category = categories[3],Name="Seroquel", Description="Seroquel is used to treat bipolar disorder (manic depression) in adults and children who are at least 10 years old.", BatchNo="BEC-FF3", Dosage="2 times", Formula="Quetiapine (kwe TYE a peen)", MafBy="Getz Pharma", Price=65.00M, MafDate= new DateTime(2017, 1, 1),ExpDate= new DateTime(2019, 1, 5)},
                new Medicine {Category = categories[0],Name="Abilify", Description="Maintenance Treatment: Maintenance of efficacy in schizophrenia was demonstrated in a trial involving patients with schizophrenia who had been symptomatically stable on other antipsychotic medications for periods of 3 months or longer.", BatchNo="BEC-FF3", Dosage="2 times", Formula="ARIPIPRAZOLE 2mg", MafBy="Getz Pharma", Price=65.00M, MafDate= new DateTime(2017, 1, 1),ExpDate= new DateTime(2019, 1, 5)},
                new Medicine {Category = categories[1],Name="Augmentin", Description="test augmentin", BatchNo="Fly-89", Dosage="2", Formula="fly-233", MafBy="Abbott", Price=40.00M, MafDate= new DateTime(2001, 4, 3),ExpDate= new DateTime(2002, 3, 2)},
                new Medicine {Category = categories[2],Name="brofin", Description="test", BatchNo="a-fe", Dosage="2/day, 3-times", Formula="Brof-44", MafBy="Getz", Price=150.00M, MafDate= new DateTime(2019, 9, 14),ExpDate= new DateTime(2019, 9, 25)},
            }.ForEach(m => context.Medicine.Add(m));

            base.Seed(context);
        }

    }
}
