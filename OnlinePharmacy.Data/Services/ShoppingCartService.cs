using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlinePharmacy.Data.Models;

namespace OnlinePharmacy.Data.Services
{
    public class ShoppingCartService : IShoppingCart
    {
        private readonly OnlinePharmacyContext Context;

        public ShoppingCartService(OnlinePharmacyContext context)
        {
            Context = context;
        }

        public void Add(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ShoppingCart Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShoppingCart> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }
    }
}
