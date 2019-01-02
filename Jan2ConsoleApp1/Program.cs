using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan2ConsoleApp1
{
    class Program
    {
        static double RaiseToPower(double number, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
                result *= number;

            return result;
        }

        static void Main(string[] args)
        {
            double d=RaiseToPower(2, 5);
            Console.WriteLine("The Answer is   \n");
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
