using System;

namespace Arrays_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Engin";
            string student2 = "Derin";
            string student3 = "Salih";

            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = new[] { "Salih", "Engin", "Derin" };
            string[] students3 = new[] {"Salih","Engin","Derin" };
            string[] students4 = {"Salih","Engin","Derin" };
            

            

            foreach (var student in students)
            {
                Console.WriteLine(student);               
            }

            //Multidimensional - çok boyutlu diziler
            string[,] regions = new string[7, 3];
            regions[0, 0] = "İstanbul";

            string[,] regions2 = new string[7, 3] {

                {"İstanbul", "İzmit", "Balıkesir" },
                {"Ankara", "Konya", "Çankırı" },
                {"Antalya", "Adana", "Mersin" },
                {"Rize", "Trabzon", "Samsun" },
                {"İzmir", "Muğla", "Manisa" },
                {"Kars", "Ardahan", "Muş" },
                {"Urfa", "Adıyaman", "Mardin" }                
            };

            for (int i = 0; i <= regions2.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions2.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions2[i,j]);
                }
                Console.WriteLine("******");
            }
            

        }
    }
}
