using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 홀짝 계산
            string result = (10 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);
        }
    }
}