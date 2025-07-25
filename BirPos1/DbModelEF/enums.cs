using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirPos1.DbModelEF
{
    public static class Enums
    {
        public enum PaymentType
        {
            Cash = 1,
            Card = 2,
            Transfer = 3,
            Debt = 4
        }
    }
}
