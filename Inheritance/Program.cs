using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    { 
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Erdi" }, new Student{ FirstName="Cihan"}, new Person{FirstName="Gülsüm"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadKey();
        }
    }
    class Person2
    {
        // Person2 diyip yeni bir class yaratıp diğer classları ınherit edemez, interface ile arasındaki büyük fark birden fazla class'ı inherit edemezken interfaceler birden fazla classı interface ile implemente edebiliyoruz.
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string City { get; set; }

    }
    class Student:Person
    {
        public string Departmant { get; set; }

    }
}
