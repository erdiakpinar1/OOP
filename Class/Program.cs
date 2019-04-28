using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classlar Neden var?
// Yapmak istediğimiz işlemleri gruplara ayırmak, o gruplar üzerinden başka gruplara ulaşabilmek için varlar

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yeni bir customermanager oluşturmak için ondan bir nesne üretmemiz gerekiyor. yani customerManager .... adında add ve update methodlarını kullanabilen yeni bir obje oluşturmuş oluyoruz.
            CustomerManager customerManager = new CustomerManager(); // Yeni bir instance yaratmış olduk... daha sonra add ve update methodlarını çağıracağız.
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Console.ReadLine();
        }

        // CustomerManager classı oluşturuyoruz oluşturduğumuz classa 2 adet method ekliyoruz. bunları main class içerisinden ulaşmak için kullanıcaz yani ana sınıfımız sadece başka işler yapan classları çağırarak işlemlerini sürdürecek.
        //class CustomerManager
        //{   // parametre almayan, değer döndürmeyen method yazıyoruz.
        //    public void Add()
        //    {
        //        Console.WriteLine("Customer Added!");
        //    }
        //    public void Update()
        //    {
        //        Console.WriteLine("Customer Updated!");
        //    }
        //    // baştaki commentte bahsettiğim gibi classları projeyi gruplamak ve bu şekilde parçala yönet amacı güttüğümüz yazılıydı fakat bu şekilde tek sayfa içerisine sırayla eklenmiş olan classlar proje büyüdükçe okunması ve hata bulması zorlaşacağı için farklı class sayfalarından erişmek gerekiyor. bu yüzden yeni bir class sayfası acıp main class ordan methodu çağıracak.
        //}

        class ProductManager
        {
            public void Add()
            {
                Console.WriteLine("Product Added!");
            }
            public void Update()
            {
                Console.WriteLine("Product Updated!");
            }
        }
    }
}
