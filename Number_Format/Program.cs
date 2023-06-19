using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // D : 10진수
            WriteLine("10진수: {0:D}", 123);
            WriteLine("10진수: {0:D5}", 123);         // 출력되는 정수의 자릿수를 5로 맞추고 남은 자리는 0을 채움

            // X : 16진수
            WriteLine("16진수: 0X{0:X}", 0xFF1234);
            WriteLine("16진수: 0X{0:X8}", 0xFF1234);  // 출력되는 16진수를 8자리로 맞추고, 남는 자리는 0으로 채워 출력합니다.

            // N : 숫자
            WriteLine("숫자: {0:N}", 123456789);
            WriteLine("숫자: {0:N0}", 123456789);     // 자릿수 0은 소수점 이하를 제거합니다.

            // F : 고정 소수점
            WriteLine("고정 소수점: {0:F}", 123.45);
            WriteLine("고정 소수점: {0:F5}", 123.456); // 소숫점 이하를 5자리로 맞추고, 남는 자리는 0으로 채워 출력합니다.

            // E : 공학용
            WriteLine("공학: {0:E}", 123.456789);     // E는 공학적인 지수 형식으로 출력합니다. 출력될 때는 숫자와 지수부로 표현되며, E+ 또는 E- 접두사가 붙습니다.
        }
    }
}
