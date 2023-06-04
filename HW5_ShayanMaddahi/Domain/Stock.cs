using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_ShayanMaddahi.Domain
{
    public class Stock
    {
        public Guid StockId { get; set; }
        public string Name { get; set; }
        public Guid ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductPrice { get; set; }  
    }
}
