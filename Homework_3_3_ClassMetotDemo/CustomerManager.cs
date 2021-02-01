using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_3_3_ClassMetotDemo
{
    class CustomerManager
    {
        

        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.Name + " isimli müşteri başarıyla eklenmiştir.");
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.Name + " isimli müşteri başarıyla silinmiştir.");
        }

        public void ListCustomer(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("All customers are listed below.");
                Console.WriteLine("Customer ID: " + customer.CustomerId);
                Console.WriteLine("Citizenship Number: " + customer.CitizenshipNumber);
                Console.WriteLine("Name Surname: " + customer.Name + " " + customer.Surname);
                Console.WriteLine("Phone: " + customer.Phone);
                Console.WriteLine("Email: " + customer.Email);
                Console.WriteLine("***************************");
            }
        }
    }
}
