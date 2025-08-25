using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("CampaignNoList")]
    public class CampaignNoList : BaseObject
    {
        public string CampaignOid { get; set; }
        public Guid NoCampaignOid { get; set; }
    }
}
