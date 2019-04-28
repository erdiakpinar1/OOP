using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //interfaceler �zellikle katmanlar aras�nda yo�un ge�i�lerde kullan�l�yor.
            CustomerInterface2();

            Console.ReadKey();
        }

        private static void CustomerInterface2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }
    }
}
