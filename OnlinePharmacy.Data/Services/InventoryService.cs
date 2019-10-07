using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlinePharmacy.Data.Models;

namespace OnlinePharmacy.Data.Services
{
    public class InventoryService : IInventory
    {
        private readonly OnlinePharmacyContext Context;

        public InventoryService(OnlinePharmacyContext context)
        {
            Context = context;
        }

        public void Add(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Inventory Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inventory> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Inventory inventory)
        {
            throw new NotImplementedException();
        }
    }
}
