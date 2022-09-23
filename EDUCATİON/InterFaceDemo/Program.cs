﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Robot(),
                new Manager()
            };

            foreach (var worker in workers) // butun calısanlara ÇALIS emri verdi demek yani
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
               new Manager(),
               new Worker()
            };

            foreach (var eat in eats)
            {
                eat.Eat();

            }


        }

        interface IWorker
        {
            void Work();
        }

        interface IGetSalary
        {
            void GetSalary();
        }

        interface IEat
        {
            void Eat();
        }

        class Manager : IWorker, IEat, IGetSalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class Worker : IWorker, IEat, IGetSalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }


    }
}
