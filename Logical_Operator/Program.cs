using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // and 연산 (논리곱)
            Console.WriteLine("Testing && ... ");
            Console.WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");
            Console.WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");
            Console.WriteLine();

            // or 연산 (논리합)
            Console.WriteLine("Testing || ... ");
            Console.WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");
            Console.WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");
            Console.WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");
            Console.WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");
            Console.WriteLine();

            // not 연산
            Console.WriteLine("Testing ! ... ");
            Console.WriteLine($"!True : {!true}");
            Console.WriteLine($"!False : {!false}");
            Console.WriteLine();
        }
    }
}