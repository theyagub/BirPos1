using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BirPos1.DbModelEF.Enums;

namespace BirPos1.DbModelEF
{
    public class Payment
    {
    public int Id { get; set; }

    public int SaleId { get; set; }
    public Sale Sale { get; set; }

    public decimal Amount { get; set; } // Hər hissənin ödənişi

    public PaymentType PaymentType { get; set; }

    public DateTime PaymentDate { get; set; }

    public string TransactionReference { get; set; }
    }
}
