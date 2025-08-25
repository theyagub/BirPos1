using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("ProductBarcode")]
    public class ProductBarcode : BaseObject
    {
        public string Barcode { get; set; }
        public string ProductCode { get; set; }
        public bool IsDecimalQuantity { get; set; }
        public DateTime InputDate { get; set; }
    }
}
