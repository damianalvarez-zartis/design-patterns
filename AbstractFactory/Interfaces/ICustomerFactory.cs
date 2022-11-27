using AbstractFactory.Customers;
using AbstractFactory.Models;

namespace AbstractFactory
{
    public interface ICustomerFactory
    {
        BaseCustomer CreateCustomer(CreateCustomerRequest request);
    }
}
