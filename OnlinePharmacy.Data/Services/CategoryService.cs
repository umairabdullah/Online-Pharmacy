using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlinePharmacy.Data.Models;

namespace OnlinePharmacy.Data.Services
{
    public class CategoryService : ICategory
    {
        private readonly OnlinePharmacyContext Context;

        public CategoryService(OnlinePharmacyContext context)
        {
            Context = context;
        }
        public void Add(Category category)
        {
            Context.Category.Add(category);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = Context.Category.Find(id);
            Context.Category.Remove(category);
            Context.SaveChanges();
        }

        public Category Get(int id)
        {
            return Context.Category.FirstOrDefault(c => c.CategoryId == id);
        }

        public IEnumerable<Category> GetAll()
        {
            return from c in Context.Category 
                   orderby c.CategoryName
                   select c;
        }

        public void Update(Category category)
        {
            var entry = Context.Entry(category);
            entry.State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
