using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DBModelEF_Main
{
    [Table("Seller")]
    public class Seller : BaseObject
    {
        public string Name { get; set; }
        public string PIN { get; set; }
        public string DepartmentCode { get; set; }
        public string Department { get; set; }
    }
}
