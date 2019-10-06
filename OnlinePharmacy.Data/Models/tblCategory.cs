using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlinePharmacy.Data.Models
{
    public class tblCategories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        [Column("DateCreated", Order = 1, TypeName = "date")]
        public DateTime DateCreated { get; set; }
        [Column("DateModified", Order = 2, TypeName = "date")]
        public DateTime DateModified { get; set; }
    }
}
