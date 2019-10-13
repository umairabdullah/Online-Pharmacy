using OnlinePharmacy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy.Data.Services.Interfaces
{
    public interface IMedicine
    {
        IEnumerable<Medicine> GetAll();
        Medicine Get(int id);
        void Add(Medicine medicine);
        void Update(Medicine medicine);
        void Delete(int id);
    }
}
