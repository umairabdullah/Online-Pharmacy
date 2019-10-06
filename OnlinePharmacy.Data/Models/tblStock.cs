using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacy.Data.Models
{
    public class tblStock
    {
        [Key]
        public int StockId { get; set; }
        public string StockType { get; set; }
        public string StockItem { get; set; }
        public string StockNumber { get; set; }
        public string StockDescription { get; set; }
        public bool StockAvailable { get; set; }
        public int Quantity { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CompanyId { get; set; }
        public int MedicineId { get; set; }
    }
}
