using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual product1 = new Individual
            {
                Id = 1,
                FirstName = "Kadir Uğur",
                LastName = "Mert",
                TCKimlikNo = "12345678910",
                Phone = "02125556677",
                City = 1,
                AccountBalance = 0
            };

            Individual product2 = new Individual
            {
                Id = 2,
                FirstName = "Burak",
                LastName = "Seçginer",
                TCKimlikNo = "12345678911",
                Phone = "02125656677",
                City = 1,
                AccountBalance = 0
            };

            Corporate product3 = new Corporate
            {
                Id = 3,
                Unvan = "",
                VergiNo = "",
                Phone = "03125556677",
                City = 2,
                AccountBalance = 0
            };

            IProduct[] products = new IProduct[] { product1, product2, product3 };

            ProductManager productManager = new ProductManager();

            foreach (var product in products)
            {
                productManager.Add(product);
            }

            product1.AccountBalance = 3000;
            product2.AccountBalance = 2500;

            productManager.List(products);

            productManager.Delete(product3);
        }
    }
}
