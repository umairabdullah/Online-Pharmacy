using OnlinePharmacy.Data.Models;
using OnlinePharmacy.Data.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Data.Services
{
    public class MedicineService : IMedicine
    {
        private readonly OnlinePharmacyContext dbContext;
        public MedicineService(OnlinePharmacyContext context)
        {
            dbContext = context;
        }

        public void Add(Medicine medicine)
        {
            dbContext.Medicine.Add(medicine);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var med = dbContext.Medicine.Find(id);
            dbContext.Medicine.Remove(med);
            dbContext.SaveChanges();
        }

        public Medicine Get(int id)
        {
            return dbContext.Medicine.FirstOrDefault(m => m.MedicineId == id);
        }

        public IEnumerable<Medicine> GetAll()
        {
            return from m in dbContext.Medicine
                   orderby m.Name
                   select m;
        }

        public void Update(Medicine medicine)
        {
            var entry = dbContext.Entry(medicine);
            entry.State = EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
