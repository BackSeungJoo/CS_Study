using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inc_DecrementOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 증가 연산자
            int a = 10;
            Console.WriteLine(a++);
            Console.WriteLine(++a);

            // 감소 연산자
            Console.WriteLine(a--);
            Console.WriteLine(--a);
        }
    }
}
