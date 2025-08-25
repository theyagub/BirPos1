using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("Cashier")]
    public class Cashier : BaseObject
    {
        public string CashierNumber { get; set; }
        public string Password { get; set; }
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public bool LoginUpdateContragent { get; set; }
        public bool LoginUpdateProduct { get; set; }
        public bool LoginUpdateBarcode { get; set; }
        public bool LoginUpdatePrice { get; set; }
        public bool LoginUpdateSeller { get; set; }
        public bool LoginUpdateCampaign { get; set; }
        public DateTime InputDate { get; set; }
    }
}
