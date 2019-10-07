using OnlinePharmacy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Data.Services
{
    public interface IPayment
    {
        IEnumerable<Payment> GetAll();
        Payment Get(int id);
        void Add(Payment medicine);
        void Update(Payment medicine);
        void Delete(int id);
    }
}
