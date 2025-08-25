using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("ProductCustomPrice")]
    public class ProductCustomPrice : BaseObject
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ProductCode { get; set; }
        public string Barcode { get; set; }
        public double Price { get; set; }
        public bool TaxIncludedPrice { get; set; }
        public bool IsDecimalQuantity { get; set; }
        public DateTime InputDate { get; set; }
    }
}
