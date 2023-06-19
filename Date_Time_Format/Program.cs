using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Date_Time_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;

            WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            WriteLine("24시간 형식: {0:yyyy-MM-dd hh:mm:ss (dddd)}", dt);

            CultureInfo ciKo = new CultureInfo("ko_KR");
            WriteLine();
            WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", ciKo);
            WriteLine("24시간 형식: {0:yyyy-MM-dd hh:mm:ss (dddd)}", ciKo);
            WriteLine(dt.ToString(ciKo));

            CultureInfo ciEn = new CultureInfo("en_US");
            WriteLine();
            WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", ciEn);
            WriteLine("24시간 형식: {0:yyyy-MM-dd hh:mm:ss (dddd)}", ciEn);
            WriteLine(dt.ToString(ciEn));
        }
    }
}
