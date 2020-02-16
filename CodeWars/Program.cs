using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                int result = i / 5;
                result += i / 25;
                result += i / 125;
                result += i / 625;
                result += i / 3125;
                Console.WriteLine($"{i} : {result}");
                Console.WriteLine();
                var x =int.MaxValue;
            }
            Console.ReadLine();

        }
    }
}
