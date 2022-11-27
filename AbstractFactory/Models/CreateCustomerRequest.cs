namespace AbstractFactory.Models
{
    public class CreateCustomerRequest
    {
        public string CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerAddress { get; set; }
    }
}
