using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Customers
{
    public class CompanyCustomer : BaseCustomer
    {
        public CategoryCompany Category { get; set; }
        public CompanyCustomer() : base()
        {
        }

        public override void Charge(Price amount)
        {
            Balance -= amount.BasePrice;
        }
    }
}

