using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlinePharmacy.Data.Models;

namespace OnlinePharmacy.Data.Services
{
    public class StockService : IStock
    {
        private readonly OnlinePharmacyContext Context;

        public StockService(OnlinePharmacyContext context)
        {
            Context = context;
        }

        public void Add(Stock stock)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Stock Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stock> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Stock stock)
        {
            throw new NotImplementedException();
        }
    }
}
