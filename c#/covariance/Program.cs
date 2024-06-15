using System;
using System.Collections.Generic;

namespace Covariance;

public class Program
{
    public static void PrintCustomerNames(IEnumerable<IRepository<Customer>> repositories)
    {
        foreach (var repo in repositories)
        {
            Customer customer = repo.GetItem(1);
            Console.WriteLine(customer.Name);
        }
    }

    public static void Main()
    {
        var customerRepos = new List<IRepository<Customer>>
        {
            new CustomerRepository(),
            new SpecialCustomerRepository()
        };

        PrintCustomerNames(customerRepos);
    }
}
