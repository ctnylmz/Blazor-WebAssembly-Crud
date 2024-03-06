using System;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            EmployeeManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(employeeManager);
            projectManager.Add(new InternManager());



        }
    }
    interface IPersonManager
    {
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajer Güncellendi");
        }

    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");

        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
               personManager.Add();
        }
    }
}
