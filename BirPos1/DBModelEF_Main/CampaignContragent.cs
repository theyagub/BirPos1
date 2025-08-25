using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("CampaignContragent")]
    public class CampaignContragent : BaseObject
    {
        public string CampaignOid { get; set; }
        public string ContragentCode { get; set; }
    }
}
