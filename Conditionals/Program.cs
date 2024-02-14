using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 50;

            if (number >= 70)
            {
                Console.WriteLine("Good");
            }
            else if (number >= 50)
            {
                Console.WriteLine("middle");
            }
            else if (number < 50 && number > 0)
            {
                Console.WriteLine("bad");
            }
            else
            {
                Console.WriteLine("Error");
            }

            // ----------------------------- /

            number = 20;

            switch (number)
            {
                case 10: Console.WriteLine("Number is 10"); break;
                case 20: Console.WriteLine("Number is 20"); break;
                default : Console.WriteLine("Number is not 10 or 20"); break;
            }
        }
    }
}
