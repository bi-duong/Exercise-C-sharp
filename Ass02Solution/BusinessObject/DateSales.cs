using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class DateSales
    {
        public DateTime Date { get; set; }
        public Decimal Total { get; set; }
        public int OrderCount { get; set; }
    }
}
