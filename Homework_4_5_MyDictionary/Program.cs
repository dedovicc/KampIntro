using System;

namespace Homework_4_5_MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();

            students.Add(15, "Ahmet");
            students.Add(15, "Mehmet");

            
        }
    }
}
