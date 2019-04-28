using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir Şirkette 3 tip çalışan var: işciler yöneticiler Robotlar bir class birden fazla interface implamantation yapılabilir. 
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            Console.ReadKey();
        }
    }
    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eating...");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Manager Working...");
        }
    }
    class worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eating...");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Worker Working...");
        }
    }
    class Robot : IWorker 
    {
        public void Work()
        {
            Console.WriteLine("Robot Working...");
        }
    }
}
