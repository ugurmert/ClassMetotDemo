using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.FirstName = "Kadir Uğur";
            product1.LastName = "Mert";
            product1.Phone = "02125556677";
            product1.City = 1;

            Product product2 = new Product();
            product2.FirstName = "Burak";
            product2.LastName = "Seçginer";
            product2.Phone = "02125656677";
            product2.City = 1;

            Product product3 = new Product();
            product3.FirstName = "Kerem";
            product3.LastName = "Seçer";
            product3.Phone = "03125556677";
            product3.City = 2;

            Product[] products = new Product[] {product1, product2, product3};

            ProductManager productManager = new ProductManager();

            foreach (Product product in products)
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
