using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("DocumentGifHistory")]
    public class DocumentGifHistory : BaseObject
    {
        public string DocumentOid { get; set; }
        public string DetailOid { get; set; }
        public string CampaignOid { get; set; }
        public DateTime InputDate { get; set; }
    }
}
