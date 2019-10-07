using OnlinePharmacy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Data.Services
{
    public interface IShoppingCart
    {
        IEnumerable<ShoppingCart> GetAll();
        ShoppingCart Get(int id);
        void Add(ShoppingCart medicine);
        void Update(ShoppingCart medicine);
        void Delete(int id);
    }
}
