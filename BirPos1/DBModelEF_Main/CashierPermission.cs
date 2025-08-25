using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BirPos1.services;

namespace BirPos1.DBModelEF_Main
{
    [Table("CashierPermission")]
    public class CashierPermission : BaseObject
    {
        public Guid CashierOid { get; set; }
        public virtual Cashier Cashier { get; set; }
        public Permission Permission { get; set; }
        public bool CanPermission { get; set; }
        public DateTime InputDate { get; set; }
    }
}
