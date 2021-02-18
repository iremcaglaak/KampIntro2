using System;
using System.Collections.Generic;

namespace Opp3
{
    class Program
    {
        static void Main(string[] args)
        {

            TasitKredisiManager tasitKredisiManager = new TasitKredisiManager();
            //tasitKredisiManager.Hesapla();

            IhtiyacKredisiManager ihtiyacKredisiManager = new IhtiyacKredisiManager();
            //ihtiyacKredisiManager.Hesapla();

            KonutKredisiManager konutKredisiManager = new KonutKredisiManager();
            //konutKredisiManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new KonutKredisiManager(), new List<ILoggerService> { new DatabaseLoggerService(),
                new FileLoggerService()});

            List<IKrediManager> krediler = new List<IKrediManager>()
            { ihtiyacKredisiManager, tasitKredisiManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);





        }

        private static ILoggerService FileLoggerService()
        {
            throw new NotImplementedException();
        }
    }
}
