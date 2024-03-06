using System;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1,"Çetin","Trt","Istanbul");

            Console.WriteLine(customer.City);
        }
    }
    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Hello");
        }

        public Customer(int id,string firstName,string lastName,string city)
        {
            Console.WriteLine("Id : " + id + " FirstName : " + firstName + " LastName : " + lastName);

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
