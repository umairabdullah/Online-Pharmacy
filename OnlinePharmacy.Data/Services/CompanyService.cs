using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlinePharmacy.Data.Models;

namespace OnlinePharmacy.Data.Services
{
    public class CompanyService : ICompany
    {
        private readonly OnlinePharmacyContext Context;

        public CompanyService(OnlinePharmacyContext context)
        {
            Context = context;
        }

        public void Add(Company company)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Company Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
