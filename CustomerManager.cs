using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Ekleme başarılı!"+ " " + customer.FirstName + " " + customer.LastName);
            Console.WriteLine(" ");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Silindi!" + " " + customer.FirstName + " " + customer.LastName);
            Console.WriteLine(" ");
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Id: " + customer.Id);
            Console.WriteLine("Adi: " + customer.FirstName);
            Console.WriteLine("SoyAdi:" + customer.LastName);
            Console.WriteLine("Kredi Puani:" + customer.CreditScore);
            Console.WriteLine(" ");
        }
    }
}
