using System;
using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacy.Data.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public decimal PayAmount { get; set; }
        public DateTime PayDate { get; set; }
        public string PayDescription { get; set; }
        public string PayByCreditCart { get; set; }
        public string PayByVisaCard { get; set; }
        public int OrderId { get; set; }
    }
}
