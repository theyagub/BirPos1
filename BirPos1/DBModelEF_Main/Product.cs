using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("Product")]
    public class Product : BaseObject
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string BrandCode { get; set; }
        public string BrandName { get; set; }
        public bool CustomPrice { get; set; }
        public DateTime InputDate { get; set; }
    }
}
