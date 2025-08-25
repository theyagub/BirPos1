using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BirPos1.services;

namespace BirPos1.DBModelEF_Main
{
    [Table("DocumentBase")]
    public class DocumentBase : BaseObject
    {
        public string CashOid { get; set; }
        public string DepartmentCode { get; set; }
        public string CompanyOid { get; set; }
        public string CashierOid { get; set; }
        public string DeviceNumber { get; set; }
        public string SellerNo { get; set; }
        public string SellerName { get; set; }
        public string SellerPIN { get; set; }
        public DocumentType DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string ContragentCode { get; set; }
        public float Amount { get; set; }
        public float DiscountAmount { get; set; }
        public float GifAmount { get; set; }
        public float TotalDiscountAmount { get; set; }
        public float TotalAmount { get; set; }
        public float TaxAmount { get; set; }
        public float GrandTotalAmount { get; set; }
        public bool IsClosed { get; set; }
        public DateTime CloseDate { get; set; }
        public string RefernceDocumentOid { get; set; }
        public bool IsSyncMasterApp { get; set; }
        public DateTime SyncMasterAppDate { get; set; }
        public string LastDebtInfo { get; set; }
        public bool IsCanceled { get; set; }
        public bool HfConvertSale { get; set; }
        public DateTime InputDate { get; set; }
    }
}
