using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("DocumentAuthorizedHistory")]
    public class DocumentAuthorizedHistory : BaseObject
    {
        public Guid DocumentOid { get; set; }
        public int Permission { get; set; }
        public Guid AuthorizedCashierOid { get; set; }
        public string AuthorizedCardNumber { get; set; }
        public bool IsSyncMasterApp { get; set; }
        public DateTime SyncMasterAppDate { get; set; }
        public DateTime InputDate { get; set; }
    }
}