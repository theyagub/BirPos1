using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("ProductPrice")]
    public class ProductPrice : BaseObject
    {
        public string ProductCode { get; set; }
        public string PriceTypeID { get; set; }
        public PriceType PriceType { get; set; }
        public double Price { get; set; }
        public DateTime InputDate { get; set; }
    }
}
