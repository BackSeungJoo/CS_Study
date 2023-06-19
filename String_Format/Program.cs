using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // 문자 서식화
            string result = string.Format("{0,-10}DEF", "ABC"); //ABC를 출력한 뒤 0번째 ~ -10번 째 뒤에 있는 곳에서 DEF 출력
            Console.WriteLine(result);

            string fmt = "{0,-20}{1,-15}{2,30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Baek", "Seung", "Joo");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");

        }
    }
}
