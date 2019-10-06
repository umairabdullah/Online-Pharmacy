using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlinePharmacy.Data.Models;

namespace OnlinePharmacy.Data.Services
{
    public class CategoryService : ICategory
    {
        public readonly OnlinePharmacyContext Context;

        public CategoryService(OnlinePharmacyContext context)
        {
            Context = context;
        }
        public void Add(tblCategories medicine)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public tblCategories Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tblCategories> GetAll()
        {
            return from c in Context.Category
                   select c;
        }

        public void Update(tblCategories medicine)
        {
            throw new NotImplementedException();
        }
    }
}
