﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    public class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");

        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");

        }
    }

    public class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted");

        }

        public void Update()
        {
            Console.WriteLine("MySql Updated");

        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
