using InterfacesDemo.Bussiness.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new BossManager(),
                new Robot(),
                new Worker()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }
        }
    }
}
