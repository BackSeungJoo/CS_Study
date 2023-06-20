using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 덧셈
            int a = 111 + 222;
            Console.WriteLine($"a : {a}");

            // 뺄셈
            int b = a - 100;
            Console.WriteLine($"b ; {b}");

            // 곱셈
            int c = b * 10;
            Console.WriteLine($"c : {c}");

            // 나눗셈
            double d = c / 6.3;
            Console.WriteLine($"d : {d}");

            Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})");
        }
    }
}
