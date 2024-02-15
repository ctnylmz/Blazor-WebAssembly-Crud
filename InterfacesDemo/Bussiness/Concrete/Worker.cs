using InterfacesDemo.Bussiness.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo.Bussiness.Concrete
{
    public class Worker : IWorker, IEat, ISalary
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
}
