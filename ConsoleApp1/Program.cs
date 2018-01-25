using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Enter a number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your number is {num1}");
            Console.ReadLine();
        }
    }
}
