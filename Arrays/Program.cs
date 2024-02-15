using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // -------------------------------- //

            string[,] citys = new string[3, 2]
            {
                { "İstanbul", "25M"},
                {"Ankara" , "15M" },
                { "İzmir" , "10M"}
            };


            for (int i = 0; i < citys.GetUpperBound(0); i++)
            {
                for (int j = 0; j < citys.GetUpperBound(0); j++)
                {
                    Console.WriteLine(citys[i,j]);
                }
                Console.WriteLine("--");
            }

            // -------------------------------- //


        }
    }
}
