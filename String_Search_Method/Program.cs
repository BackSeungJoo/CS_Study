using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Search_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // C# 문자열 탐색 예제

            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            //indexOf()
            WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            WriteLine("IndexOf 'M' : {0}", greeting.IndexOf("d"));

            //LastIndexOf()
            WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            WriteLine("LastIndexOf 'G' : {0}", greeting.LastIndexOf("o"));

            //StartsWith()
            WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

            //EndsWith()
            WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            WriteLine("EndsWith 'Morning : {0}", greeting.EndsWith("Morning"));

            //Contains()
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Good"));
            WriteLine("Contains 'Morning : {0}", greeting.Contains("Morning"));

            //Replace()
            WriteLine("EndsWith 'Morning' with 'Evening' : {0}", greeting.Replace("Morning", "Evening"));

            
        }
    }
}
