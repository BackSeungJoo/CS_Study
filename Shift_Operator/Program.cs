using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing << ...");

            int a = 1;
            
            // 1바이트로 나타낼 수 있는 수는 256가지. 8자리의 16진수면 int형식이 표현하는 모든 수를 나타낼 수 있음
            Console.WriteLine("a      : 10진수 : {0:D5} 16진수 : (0x{0:X8})", a);   
            Console.WriteLine("a << 1 : 10진수 : {0:D5} 16진수 : (0x{0:X8})", a << 1);   
            Console.WriteLine("a << 2 : 10진수 : {0:D5} 16진수 : (0x{0:X8})", a << 2);   
            Console.WriteLine("a << 5 : 10진수 : {0:D5} 16진수 : (0x{0:X8})", a << 5);
            Console.WriteLine();

            // 양수
            Console.WriteLine("Testing >> ...");
            int b = 255;
            Console.WriteLine("b      : 10진수 : {0:D5} 16진수 : (0x{0:X8})", b);
            Console.WriteLine("b >> 1 : 10진수 : {0:D5} 16진수 : (0x{0:X8})", b >> 1);
            Console.WriteLine("b >> 2 : 10진수 : {0:D5} 16진수 : (0x{0:X8})", b >> 2);
            Console.WriteLine("b >> 5 : 10진수 : {0:D5} 16진수 : (0x{0:X8})", b >> 5);
            Console.WriteLine();

            // 음수
            Console.WriteLine("Testing >> 2 ...");
            int c = -255;
            Console.WriteLine("b      : 10진수 : {0:D5} 16진수 : (0x{0:X8})", c);
            Console.WriteLine("b >> 1 : 10진수 : {0:D5} 16진수 : (0x{0:X8})", c >> 1);
            Console.WriteLine("b >> 2 : 10진수 : {0:D5} 16진수 : (0x{0:X8})", c >> 2);
            Console.WriteLine("b >> 5 : 10진수 : {0:D5} 16진수 : (0x{0:X8})", c >> 5);
            Console.WriteLine();
        }
    }
}
