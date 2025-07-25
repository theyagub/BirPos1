using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DbModelEF
{
    [Table("ProductCategory")]
    public class ProductCategory:BaseObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
