using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "홍길동";
            int age = 23;
            WriteLine($"{name,-10},{age:D3}");

            name = "김수박";
            age = 30;
            WriteLine($"{name},{age,-10:D3}");

            name = "이호랑";
            age = 17;
            WriteLine($"{name},{(age > 20 ? "성인" : "미성년자")}");
        }
    }
}
