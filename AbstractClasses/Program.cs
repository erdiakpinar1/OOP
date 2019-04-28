using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{   //abstarct classlar Inheritance(virtual methodlar) ile interfacesı birleştirilmiş hali olarak düşünülebilir.
    class Program
    {
        static void Main(string[] args)
        {
            //abstract classlar new'lenemez 
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();

            //eklme herkesde aynı delete her class için implanmente edilmesi gereken bir yapıdır.
            Console.ReadKey();
        }
    }
    abstract class Database
    {   //inheritance da olduğu gibi classlar sadece 1 tane abstract eklenebilir interfacede birden fazla ekleme yapılabilinir. 
        // tamamlanmış method
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        //tammalanmamış method
        public abstract void Delete();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
