using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ProductManager
    {
        public void Add(IProduct product)
        {
            product.AccountBalance = 0;
            Console.WriteLine(product.Id + " başarıyla eklendi!");
        }
        public void List(IProduct[] products)
        {
            Console.WriteLine("---------- Müşteri Listesi ----------");
            foreach (var product in products)
            {
                Console.WriteLine("\nID: " + product.Id + "\nTelefon: " + product.Phone + "\nHesap Bakiyesi: " + product.AccountBalance);
            }
            Console.WriteLine("\n");
        }
        public void Delete(IProduct product)
        {
            Console.WriteLine(product.Id + " başarıyla silindi!");
        }
    }
}
