using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("Contragent")]
    public class Contragent : BaseObject
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string GSM { get; set; }
        public string Contract { get; set; }
        public string PriceTypeID { get; set; }
        public string PriceTypeName { get; set; }
        public bool TaxIncludePrice { get; set; }
        public double TaxPercentage { get; set; }
        public double debt { get; set; }
        public DateTime InputDate { get; set; }
    }
}
