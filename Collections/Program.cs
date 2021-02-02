using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrray Diziler
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            ////System.IndexOutOfRangeException hatası alırız.
            ////Arrayleri oluştururken hangi sınırda oluşturduysak onun dışına çıkamayız.
            //isimler[4] = "İlker";
            ////isimler[4] = "İlker";
            ////Arraylerde sabitlik var 4 elemanlı tanımladıysak eleman sayısını artıramıyoruz.
            ////new leyerek artırım yaparız ama bu sefer de arraydeki önceki elemanları kaybederiz.
            ////Bu kullanım kısıtlarından dolayı hem C#'da hem de Javada genellikle array kullanılmaz collectionslar List<> kullanılır.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            
            
        }
    }
}
