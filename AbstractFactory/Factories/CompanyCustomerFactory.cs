using AbstractFactory.Customers;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class CompanyCustomerFactory ///: ICustomerFactory
    {
        private const int _maxNumberClients = 1000;
        public static BaseCustomer CreateCustomer(CreateCustomerRequest request)
        {
            switch (request.Type)
            {
                case CustomerType.Company:
                    CreateCompanyCustomer(request);
                    break;
                case CustomerType.Individual:
                    CreateIndividualCustomer(request);
                    break;
            }
            throw new ArgumentException("Customer Type unsupported");
        }

        private static CompanyCustomer CreateCompanyCustomer(CreateCustomerRequest request)
        {
            Random rnd = new();

            return new CompanyCustomer
            {
                Id = rnd.Next(_maxNumberClients),
                Name = request.CustomerName,
                Address = request.CustomerAddress,
                Phone = request.CustomerPhone
            };
        }

        private static IndividualCustomer CreateIndividualCustomer(CreateCustomerRequest request)
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
