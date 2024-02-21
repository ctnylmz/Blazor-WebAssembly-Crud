using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Engin";

            Person person2 = new Person();
            person2.FirstName = "Murat";

            Person person3 = new Person();
            person3.FirstName = "ÇETİN";
            person3.LastName = "Trt";
            person3.NationalIdentity = 123;
            person3.DateOfBirthYAear = 2000;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person3 );
        }

       static void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }
    }
}
