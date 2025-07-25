using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DbModelEF
{
    [Table("Sale")]
    public class Sale
    {
        public int Id { get; set; }

        public DateTime SaleDate { get; set; }

        public int SellerID { get; set; }
        public Seller Seller { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public decimal TotalAmount { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
