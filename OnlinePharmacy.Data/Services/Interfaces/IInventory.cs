using OnlinePharmacy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Data.Services
{
    public interface IInventory
    {
        IEnumerable<Inventory> GetAll();
        Inventory Get(int id);
        void Add(Inventory medicine);
        void Update(Inventory medicine);
        void Delete(int id);
    }
}
