using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Change_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("ToLower() : '{0}'","ABC".ToLower());
            WriteLine("ToUpper() : '{0}'","abc".ToLower());

            WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
            WriteLine("ReMove() : '{0}'", "I Don't Love You".Remove(2, 6));

            WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
            WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());
            WriteLine("TrimEnd() : '{0}'", " No Spaces ".TrimEnd());
        }
    }
}
