using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DbModelEF
{
    [Table("Return")]
    public class Return : BaseObject
    {
        public int Id { get; set; }
        public int SaleId { get; set; }         // Hansı satışdan qaytarılır
        public Sale Sale { get; set; }

        public int ProductId { get; set; }      // Hansı məhsul qaytarılır
        public Product Product { get; set; }

        public int Quantity { get; set; }       // Qaytarılan miqdar
        public DateTime ReturnDate { get; set; }

        public string Reason { get; set; }      // Qaytarma səbəbi
    }

}
