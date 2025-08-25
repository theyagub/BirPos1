using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("ProductExtraCode")]
    public class ProductExtraCode : BaseObject
    {
        public string ProductCode { get; set; }
        public string ExtraCode { get; set; }
    }
}
