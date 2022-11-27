using AbstractFactory.Customers;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class CompanyCustomerFactory : ICustomerFactory
    {
        private const int _maxNumberClients = 1000;
        public BaseCustomer CreateCustomer(CreateCustomerRequest request)
        {
            Random rnd = new();

            return new IndividualCustomer
            {
                Id = rnd.Next(_maxNumberClients),
                Name = request.CustomerName,
                Address = request.CustomerAddress,
                Phone = request.CustomerPhone
            };
        }
    }
}
