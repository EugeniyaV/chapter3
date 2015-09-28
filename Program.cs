using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("The value {0} in various formats: ", a);
            Console.WriteLine("c format : {0:c}", a);
            Console.WriteLine("d9 format: {0:d9}", a);
            Console.WriteLine("f4 format : {0:f4}", a);
            Console.WriteLine("n format: {0:n}", a);
            Console.WriteLine("E format : {0:E}", a);
            Console.WriteLine("e format: {0:e}", a);
            Console.WriteLine("X format : {0:X}", a);
            Console.WriteLine("x format: {0:x}", a);
            Console.WriteLine("g format: {0:g}", a);
            Console.ReadLine();
        }
    }
}
