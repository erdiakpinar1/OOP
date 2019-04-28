using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id= 1;
            customer.FirstName = "Erdi";
            customer.LastName = "Akpınar";
            customer.City = "İstanbul";
            //objeler oluşturulduktan sonra üstteki şekilde özellikleri ekleyebiliyoruz bir ikinci yöntme ise :
            // ctrl + space hangi özelliklere erişebilidğini gösteriyor.
            Customer customer2 = new Customer
            {   //  prop içerisindeki set bloğunu çalıştırır.
                Id = 2,
                FirstName = "Cihan",
                LastName = "Akpınar",
                City = "İstanbul"
            };

            Console.WriteLine(customer2.FirstName/*prop içerisindeki get bloğunu çalıştırır.*/);

            Console.ReadKey();
        }
    }
}
