using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class Price
    {
        public decimal BasePrice { get; set; }
        public decimal VAT { get; set; }

        public decimal Total()
        {
            //TODO: for now
            return BasePrice;
        }
    }
}
