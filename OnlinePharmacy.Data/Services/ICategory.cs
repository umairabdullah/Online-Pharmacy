using OnlinePharmacy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Data.Services
{
    public interface ICategory
    {
        IEnumerable<tblCategories> GetAll();
        tblCategories Get(int id);
        void Add(tblCategories medicine);
        void Update(tblCategories medicine);
        void Delete(int id);
    }
}
