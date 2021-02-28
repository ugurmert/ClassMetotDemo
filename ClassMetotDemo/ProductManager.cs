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
            Console.WriteLine(product.FirstName + " " + product.LastName + "\nbaşarıyla eklendi");
            Console.WriteLine("\n----------\n");
        }
        public void List(Product[] products)
        {
            Console.WriteLine("---------- Müşteri Listesi ----------");
            foreach (Product product in products)
            {
                Console.WriteLine("\nAd Soyad: " + product.FirstName + " " + product.LastName + "\nTelefon: " + product.Phone + "\nHesap Bakiyesi: " + product.AccountBalance);
            }
            Console.WriteLine("\n----------\n");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.FirstName + " " + product.LastName + "\nbaşarıyla silindi");
        }
    }
}
