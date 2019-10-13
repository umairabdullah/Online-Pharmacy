using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlinePharmacy.Data.Models
{
    public class Category
    {
        [Key, Column(Order = 0)]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        [Column("DateCreated", TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        [Column("DateModified", TypeName = "date")]
        public DateTime? DateModified { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
    }
}
