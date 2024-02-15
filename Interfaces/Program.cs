using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[2] {
                new SqlServerCustomerDal(),
                new MySqlServerCustomerDal()
                };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }
    }

}
