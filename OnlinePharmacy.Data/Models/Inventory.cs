using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacy.Data.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }
        public string InvItem { get; set; }
        public string InvType { get; set; }
        public string InvDescription { get; set; }
        public string InvNumber { get; set; }
        public int StockId { get; set; }
    }
}
