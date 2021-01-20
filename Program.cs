using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id =458315;
            customer1.FirstName = "Can";
            customer1.LastName = "Atilgan";
            customer1.PhoneNumber = 05545555555;
            customer1.IdNumber = 12345678910;
            customer1.CreditScore = 1567;

            Customer customer2 = new Customer();
            customer2.Id =459354;
            customer2.FirstName = "Derya";
            customer2.LastName = "Olsun";
            customer2.PhoneNumber= 05545555555;
            customer2.IdNumber = 12345548910;
            customer2.CreditScore = 1587;

            Customer[] customers = new Customer[] {customer1,customer2 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.PhoneNumber);
                Console.WriteLine(customer.IdNumber);
                Console.WriteLine(customer.CreditScore);
                Console.WriteLine("*************");
            }

            Console.WriteLine("------------*****----------");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            customerManager.Delete(customer2);

            customerManager.List(customer1);
            customerManager.List(customer2);
        }
    }
}
