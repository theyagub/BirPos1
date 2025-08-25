using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("ApplicationVersion")]
    public class ApplicationVersion : BaseObject
    {
        public string AppVersion { get; set; }
        public string AppPath { get; set; }
        public bool MustUpdate { get; set; }
        public string Target { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime InputDate { get; set; }
    }
}
