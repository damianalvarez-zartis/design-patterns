using AbstractFactory.Models;

namespace AbstractFactory.Customers
{
    public class IndividualCustomer : BaseCustomer
    {
        public string Email { get; set; } = string.Empty;
        public bool IsSubscribed { get; set; } = false;
        public IndividualCustomer() : base()
        {
        }

        public override void Charge(Price amount)
        {
            Balance -= amount.BasePrice + (amount.BasePrice * amount.VAT);
        }
    }
}
