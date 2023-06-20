using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Wise_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 10;

            // 비트 and 연산
            Console.WriteLine($"{a} & {b} : {a & b}");
            // 비트 or 연산
            Console.WriteLine($"{a} | {b} : {a | b}");
            // 비트 xor 연산
            Console.WriteLine($"{a} ^ {b} : {a ^ b}");

            // 비트 not 연산
            int c = 255;
            Console.WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c, ~c);
        }
    }
}
