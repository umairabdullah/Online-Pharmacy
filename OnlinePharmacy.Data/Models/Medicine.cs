using System;
using System.ComponentModel.DataAnnotations;

namespace OnlinePharmacy.Data.Models
{
    public class Medicine
    {
        [Key, Column(Order = 0)]
        public int MedicineId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column("MafDate", TypeName = "date")]
        public DateTime? MafDate { get; set; }
        public string BatchNo { get; set; }
        [Column("ExpDate", TypeName = "date")]
        public DateTime? ExpDate { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Dosage { get; set; }
        public string Formula { get; set; }
        public string MafBy { get; set; }
        public byte[] Image { get; set; }
        public bool Status { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

    }
}
