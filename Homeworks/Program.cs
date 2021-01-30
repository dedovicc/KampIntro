using System;
using System.Collections.Generic;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(){ ProductId = 1, ProductName = "Elma", CategoryId = 5, CategoryName = "Meyve" };

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Ispanak";
            product2.CategoryId = 2;
            product2.CategoryName = "Sebze";

            Product product3;

            product3 = new Product() { ProductId = 3, ProductName = "Armut", CategoryId = 1, CategoryName = "Meyve" };

            
            Product[] products = new Product[] { product1, product2, product3 };

            Console.WriteLine("*****foreach*****");
            foreach (var product in products)
            {
                Console.WriteLine("Ürün ID: " + product.ProductId + " Ürün Adı: " + product.ProductName + " Kategori ID: " + product.CategoryId + " Kategori Adı: " + product.CategoryName);
            }

            Console.WriteLine("*****while*****");
            int i = 0;
            while (i < products.Length)
            {
                
                Console.WriteLine("Ürün ID: " + products[i].ProductId + " Ürün Adı: " + products[i].ProductName + " Kategori ID: " + products[i].CategoryId + " Kategori Adı: " + products[i].CategoryName);
                i++;
            }

            Console.WriteLine("*****for*****");
            for (int j = 0; j < products.Length; j++)
            {
                Console.WriteLine("Ürün ID: " + products[j].ProductId + " Ürün Adı: " + products[j].ProductName + " Kategori ID: " + products[j].CategoryId + " Kategori Adı: " + products[j].CategoryName);
            }
            
        }
    }
}
