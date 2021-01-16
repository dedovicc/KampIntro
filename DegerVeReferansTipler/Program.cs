using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bellekte stack ve heap diye iki tane alan var.
            //Değer tipler stackde oluşuyor ve herşey stackde gerçekleşiyor. sayi1'in değeri eşittir 10 diye okuruz.

            //Referans tipler tanımlaması stackde oluşuyor. new dediğimiz anda sayilar1[] için heap de yeni bir alan oluştur ve değerini oraya at.
            //new demek bellekten yeni bir adres oluştur. Heapde
            //sayilar1 in referans numarası sayilar2 nin referans numarasına eşittir.
            //sayilar1 in eski referansını da garbage collector bellekten uçuruyor

            //Burda değer tipi anlatmış oldu.
            //Sayısal veri tipleri : int, decimal, float, double, boolean = değer tip diyoruz.
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 = 30, sayi2 = 65 olur

            //Burda referans tipi anlatmış oldu.
            //Bir array, bir class, interface = referans tip olarak çıkar.
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = ??999 olur
            
        }
    }
}
