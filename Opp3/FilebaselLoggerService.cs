using System;

namespace Opp3
{
    class FilebaselLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("veri tabanına loglandı.");
        }
    }
}
