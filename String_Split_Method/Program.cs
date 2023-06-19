using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Split_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String greeting = "Good morning.";

            // 0 부터 시작해서 길이가 5인 문자열을 반환
            WriteLine(greeting.Substring(0, 5)); // "Good"

            // 5부터 끝까지의 문자열을 반환
            WriteLine(greeting.Substring(5));    // "morning"
            WriteLine();

            // greeting 문자열을 공백을 기준으로 분리합니다.
            string[] arr = greeting.Split(new string[] { " " }, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);

            // arr 배열의 각 요소를 출력합니다.
            foreach(string element in arr)
            {
                WriteLine("{0}", element);
            }
        }
    }
}
