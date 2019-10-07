using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlinePharmacy.Data.Models;

namespace OnlinePharmacy.Data.Services
{
    public class OrderMedicineService : IOrderMedicine
    {
        private readonly OnlinePharmacyContext Context;

        public OrderMedicineService(OnlinePharmacyContext context)
        {
            Context = context;
        }

        public void Add(OrderMedicine orderMedicine)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OrderMedicine Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderMedicine> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderMedicine orderMedicine)
        {
            throw new NotImplementedException();
        }
    }
}
