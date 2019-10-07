using OnlinePharmacy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Data.Services
{
    public interface ICompany
    {
        IEnumerable<Company> GetAll();
        Company Get(int id);
        void Add(Company medicine);
        void Update(Company medicine);
        void Delete(int id);
    }
}
