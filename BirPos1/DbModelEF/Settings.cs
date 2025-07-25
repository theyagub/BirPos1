using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DbModelEF
{
    class Settings
    {
        [Table("Setting")]
        public class Setting
        {
            public int Id { get; set; }
            public string Key { get; set; }      // Parametr adı, məsələn "TaxRate"
            public string Value { get; set; }    // Parametr dəyəri, məsələn "18"
        }
    }
}
