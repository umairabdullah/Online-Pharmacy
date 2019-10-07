using OnlinePharmacy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Data.Services
{
    public interface IStock
    {
        IEnumerable<Stock> GetAll();
        Stock Get(int id);
        void Add(Stock medicine);
        void Update(Stock medicine);
        void Delete(int id);
    }
}
