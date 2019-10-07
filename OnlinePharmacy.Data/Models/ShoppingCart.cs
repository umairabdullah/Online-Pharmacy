using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacy.Data.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartId { get; set; }
        public int TotalItem { get; set; }
        public string ProductName { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal BillingAmount { get; set; }
        public decimal AvailableBalance { get; set; }
        public decimal DuesOnProduct { get; set; }
        public DateTime PaidDate { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
    }
}
