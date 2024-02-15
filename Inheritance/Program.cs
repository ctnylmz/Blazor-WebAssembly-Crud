using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[2]
            {
                new Customer
                {
                    FirstName = "Engin"
                },
                new Student {
                    FirstName = "Derin"
                },
            };

            foreach (Person p in person)
            {
                Console.WriteLine(p.FirstName);
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
