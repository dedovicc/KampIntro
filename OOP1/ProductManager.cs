using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //Encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        //void emir kipinde git ekle, git güncelle, git bişeyyap anlamında void tanımlarız.
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }


    }
}
