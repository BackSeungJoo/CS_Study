using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Coalescing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int?은 Nullable 타입으로, null 값을 가질 수 있는 정수형 변수를 선언할 수 있도록 합니다.
            int? num = null;        
            Console.WriteLine($"{num ?? 0}");   // num이 null이면 0을 출력

            num = 150;
            Console.WriteLine($"{num ?? 0}");   // num이 null이 아니기 때문에 150을 출력

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");   // str이 null이면 Default를 출력

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");   // str이 null이 아니기 때문에 str의 값을 출력
        }
    }
}
