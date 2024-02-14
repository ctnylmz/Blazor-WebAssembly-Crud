using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Calculate(10, 20);

            Add(result);

            // ------------------------------------------- //

            result = SuperCalculate(10,20,30,40,50,60,70,80,90,100);
            
            Add(result);

        }


        static void Add(int add)
        {
            Console.WriteLine("Added " + add);
        }

        static int Calculate(int number, int number2)
        {
            return number + number2;
        }


        static int Calculate(int number, int number2, int number3)
        {
            return number + number2 + number3;
        }

        static int SuperCalculate(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
