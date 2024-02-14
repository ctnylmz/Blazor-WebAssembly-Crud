using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            byte number1 = 100;
            short number2 = 10000;
            int number3 = 1000000000;
            long number4 = 1000000000000000000;


            decimal numberOne = 10.40000000000000m;
            double numberTwo =  10.00000000000000000000000000000000;

            Console.WriteLine("Number1 is " + number1);
            Console.WriteLine("Number1 is {0}", number2);
            Console.WriteLine("Number1 is " + number3);
            Console.WriteLine("Number1 is " + number4);

            Console.WriteLine("Number1 is " + numberOne);
            Console.WriteLine("Number1 is " + numberTwo);

            //---------------------------------------------------//
            char character = 'h';
            string word = "hello";

            Console.WriteLine("character is " + character);
            Console.WriteLine("word is " + word);

            //---------------------------------------------------//

            bool condition = false;

            //---------------------------------------------------//

            //enum
            Console.WriteLine(Days.Friday);


            //---------------------------------------------------//

        }

        enum Days
        {
            Monday , Tuesday, Wednesday, Friday, Saturday,Sunday
        }

        enum result
        {
            Error = 10 , Success = 20, Worning = 30, info = 40
        }

    }
    }
