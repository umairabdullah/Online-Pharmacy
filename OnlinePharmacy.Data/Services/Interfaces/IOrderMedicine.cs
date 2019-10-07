using OnlinePharmacy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Data.Services
{
    public interface IOrderMedicine
    {
        IEnumerable<OrderMedicine> GetAll();
        OrderMedicine Get(int id);
        void Add(OrderMedicine medicine);
        void Update(OrderMedicine medicine);
        void Delete(int id);
    }
}
