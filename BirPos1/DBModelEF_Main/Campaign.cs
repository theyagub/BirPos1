using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static BirPos1.services;

namespace BirPos1.DBModelEF_Main
{
    [Table("Campaign")]
    public class Campaign : BaseObject
    {
        public int GroupOrderNo { get; set; }
        public int OrderNo { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int WorkingCount { get; set; }
        public int ApplyDocumentTotalAmount { get; set; }
        public double TotalAmount { get; set; }
        public double DiscountPercentage { get; set; }
        public bool IsActive { get; set; }
        public ApplyContragentType ApplyContragentType { get; set; }
        public CriteriaType CriteriaType { get; set; }
        public int CriteriaQuantity { get; set; }
        public bool CriteriaQuantityConvertToAmount { get; set; }
        public GifType GifType { get; set; }
        public string GifCriteria { get; set; }
        public int GifQuantity { get; set; }
        public DateTime InputDate { get; set; }
    }
}
