using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // I ile başlaralar standart.
            PersonManager personManager = new PersonManager();
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "Erdi",
            //    LastName = "Akpınar",
            //    Adress = "İstanbul"
            //};
            //alttaki gösterimle üsteki aynı kod fazlalığını önlemek için yazılmıştır.
            personManager.Add(new Customer { Id = 1, FirstName = "Erdi", LastName = "Akpınar", Adress = "İstanbul" });

            Student student = new Student
            {
                Id = 1,
                FirstName = "Cihan",
                LastName = "Akpınar",
                Departmant = "Computer Sciences"
            };
            personManager.Add(student);

            Console.ReadKey();
        }
    }
    interface IPerson
    {
        // bir temel nesne oluşturup bütün nesneleri ondan implemente etmektir. yani ör: bizim cutomer diye bir classımız olsun bir tanede student classımız var bunlara somut Iperson a ise soyut nesneler denir.  soyut nesneler tekbaşlarına hiçbirşey ifade etmezler. aslında bize lazım olan bir müşteri veya öğrenci ile ilgili iş yapmaktır. Fakat oluşturulmuş olan bu iki classta bie person dır. bunun için deriz ki customer sen bir personsın ve student sen bir personsın. bu şu anlama gelir. Ipersonda tanımlanan prop diğerleri içinde geçerlidir. 
        // ınterfaceler yazılırken içerisine acsses modifer yazılmamalıdır sadece değişken tipi dönüş değeri varsa dönüş değeri yazılmalıdır.
        int Id { get; set; }
        string FirstName{ get; set; }
        string LastName{ get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress{ get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
   
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
