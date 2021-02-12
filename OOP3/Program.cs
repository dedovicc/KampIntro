using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //Interfaceleri birbirinin alternatifi olan ama kod içeriği farklı olan durumlar için kullanırız
        //Interface onu implemente eden classın referansını tutabilir.
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
