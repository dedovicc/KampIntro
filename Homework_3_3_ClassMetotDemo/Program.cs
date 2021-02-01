using System;
using System.Collections.Generic;

namespace Homework_3_3_ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CitizenshipNumber = "11111111111";
            customer1.Name = "Ahmet";
            customer1.Surname = "Mehmet";
            customer1.Phone = "5555555555";
            customer1.Email = "test@test.com";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CitizenshipNumber = "11111111111";
            customer2.Name = "Ali";
            customer2.Surname = "Veli";
            customer2.Phone = "5555555555";
            customer2.Email = "test@test.com";

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CitizenshipNumber = "11111111111";
            customer3.Name = "Ahmet";
            customer3.Surname = "Mehmet";
            customer3.Phone = "5555555555";
            customer3.Email = "test@test.com";

            Customer[] customers = new[] { customer1, customer2, customer3 };

            CustomerManager manager = new CustomerManager();

            

            manager.CustomerAdd(customer1);
            manager.CustomerDelete(customer2);


            List<Customer> customers1 = new List<Customer>();
            customers1.Add(customer1);
            customers1.Add(customer2);

            manager.ListCustomer(customers1);



        }
    }
}
