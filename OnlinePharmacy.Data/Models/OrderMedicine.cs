using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacy.Data.Models
{
    public class OrderMedicine
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderDescription { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderPlace { get; set; }
        public bool OrderCancel { get; set; }
        public string OrderConfirmed { get; set; }
        public int UserId { get; set; }
    }
}
