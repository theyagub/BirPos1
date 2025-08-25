using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BirPos1.services;

namespace BirPos1.DBModelEF_Main
{
    [Table("ReportData")]
    public class ReportData : BaseObject
    {
        public string Name { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Data { get; set; }
        public byte[] DefaultReport { get; set; }
        public DateTime InputDate { get; set; }
    }
}
