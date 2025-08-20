using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DbModelEF
{
    [Table("Discount")]
    public class Discount : BaseObject
    {
        public int Id { get; set; }
        public string Name { get; set; }           // Endirimin adı, məsələn "Yaz endirimi"
        public decimal Percentage { get; set; }    // Faizlə endirim, məsələn 10 (%)
        public decimal? FixedAmount { get; set; }  // Və ya sabit məbləğlə endirim

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
