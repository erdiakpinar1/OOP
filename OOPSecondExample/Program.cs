using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSecondExample
{
    class Program
    {   // Interface'i tercih etmemizin amacı Database'de loglama ayrı kullanılır, file ve sms'de de loglama kodları ayrı şekilde yazılmıştır. Yani kullanan herkesin ayrı ayrı implamantansyon yapmaları gerktiği için kullandık. Fakat böyle olmsaydı örnek : Database  ile file'a yazarken kodlar aynı olsaydı sadece sms için değişiyor olsaydı o zaman virtual kullnmak daha mantıklı olurdu. abstract için bir operasyonu herkes değiştirecek ama bir tane operasyon heryerde aynı ozaman abstract yapılması gerekir.
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new SmsLogger();
            //customerManager.Logger = new Logger();
            //customerManager.Logger = new FileLogger();
            customerManager.Add();
            Console.ReadKey();
        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; } // property injection 
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }

    class Logger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms!");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
