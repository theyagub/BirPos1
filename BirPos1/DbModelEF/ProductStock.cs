using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DbModelEF
{
    [Table("ProductStock")]
    class ProductStock
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; } // mövcud miqdar
        public decimal PurchasePrice { get; set; } // alış qiyməti
        public DateTime LastUpdated { get; set; }
    }
}
