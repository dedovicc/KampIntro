using System;

namespace Homework_5_3_AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtendedClass extendedClass = new ExtendedClass();
            extendedClass.Method1();
            extendedClass.Method2();
        }

        
    }

    public abstract class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("abstract classın içerisindeki abstract olmayan method çalıştırıldı");
        }
        public abstract void Method2();
    }

    public class ExtendedClass : BaseClass
    {
        public override void Method2()
        {
            Console.WriteLine("Abstract classın içerisnde imzası bulunan Method2 ExtendedClassın içerisinde override edilerek çalıştırıldı.");
        }
    }
}
