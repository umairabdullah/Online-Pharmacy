using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacy.Data.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public string CompanyDescription { get; set; }
        public string Location { get; set; }
    }
}
