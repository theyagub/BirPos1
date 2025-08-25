using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("DisplayDocument")]
    public class DisplayDocument : BaseObject
    {
        public Guid DocumentOid { get; set; }
        public bool IsActive { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseDate { get; set; }
        public DateTime InputDate { get; set; }
    }
}
