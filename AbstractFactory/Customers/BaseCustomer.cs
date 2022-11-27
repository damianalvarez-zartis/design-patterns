using AbstractFactory.Models;

namespace AbstractFactory.Customers
{
    public abstract class BaseCustomer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public decimal Balance { get; set; } = 0;

        public abstract void Charge(Price amount);
    }
}
