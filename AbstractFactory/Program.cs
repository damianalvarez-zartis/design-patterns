// See https://aka.ms/new-console-template for more information
using AbstractFactory.Factories;
using AbstractFactory.Models;

Console.WriteLine("Hello, World!");

CreateCustomerRequest request = new CreateCustomerRequest()
{
    CustomerName = "I'm an individual customer",
    CustomerPhone = "+12 3546789123",
    CustomerAddress = "Individual Customer st, 1 - London",
    Type = AbstractFactory.Customers.CustomerType.Individual
};

var customer1 = CompanyCustomerFactory.CreateCustomer(request);

CreateCustomerRequest request2 = new CreateCustomerRequest()
{
    CustomerName = "I'm a company customer",
    CustomerPhone = "+98 7654321987",
    CustomerAddress = "Company Customer st, 32 - Manchester",
    Type = AbstractFactory.Customers.CustomerType.Individual
};

var customer2 = CompanyCustomerFactory.CreateCustomer(request);


