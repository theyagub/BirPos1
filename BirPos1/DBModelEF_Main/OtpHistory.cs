using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("OtpHistory")]
    public class OtpHistory : BaseObject
    {
        public string ContragentCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Sms { get; set; }
        public bool IsSyncMasterApp { get; set; }
        public DateTime SyncMasterAppDate { get; set; }
        public DateTime InputDate { get; set; }
    }
}
