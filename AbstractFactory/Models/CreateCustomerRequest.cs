using AbstractFactory.Customers;

namespace AbstractFactory.Models
{
    public class CreateCustomerRequest
    {
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerAddress { get; set; }
        public CustomerType Type { get; set; }
    }
}
