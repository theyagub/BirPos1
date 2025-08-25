using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BirPos1.services;

namespace BirPos1.DBModelEF_Main
{
    [Table("CashLoginHistory")]
    public class CashLoginHistory : BaseObject
    {
        public string CashierOid { get; set; }
        public LoginType LoginType { get; set; }
        public bool IsSyncMasterApp { get; set; }
        public DateTime SyncMasterAppDate { get; set; }
        public DateTime InputDate { get; set; }
    }
}
