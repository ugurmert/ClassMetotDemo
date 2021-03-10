using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ProductManager
    {
        public void Add(Product product)
        {
            product.AccountBalance = 0;
            Console.WriteLine(product.Id + " başarıyla eklendi!");
        }
        public void List(Product[] products)
        {
            Console.WriteLine("---------- Müşteri Listesi ----------");
            foreach (var product in products)
            {
                Console.WriteLine("\nID: " + product.Id + "\nTelefon: " + product.Phone + "\nHesap Bakiyesi: " + product.AccountBalance);
            }
            Console.WriteLine("\n");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.Id + " başarıyla silindi!");
        }
    }
}
