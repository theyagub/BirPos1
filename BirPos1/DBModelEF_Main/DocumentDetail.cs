using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BirPos1.services;

namespace BirPos1.DBModelEF_Main
{
    [Table("DocumentDetail")]
    public class DocumentDetail : BaseObject
    {
        public int RowNumber { get; set; }


        public Guid DocumentBaseOid { get; set; }
        public virtual DocumentBase DocumentBase { get; set; }


        public DocumentType DocumentType { get; set; }
        public string ProductCode { get; set; }
        public string ProductBarcode { get; set; }
        public float Quantity { get; set; }
        public float Price { get; set; }
        public float PriceIncludeTax { get; set; }
        public float Amount { get; set; }
        public float DiscountAmount { get; set; }
        public float GifAmount { get; set; }
        public float TaxAmount { get; set; }
        public float TotalAmount { get; set; }
        public float ReturnPrice { get; set; }
        public string DepartmentCode { get; set; }
        public DateTime InputDate { get; set; }
    }
}
