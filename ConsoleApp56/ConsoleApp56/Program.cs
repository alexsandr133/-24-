using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string res, day, year,mouth;
            int mounth1, year1;
            mouth = "январь";
            mouth = "февраль";
            mouth = "март";
            mouth = "апрель";
            mouth = "май"; 
            mouth = "июнь";
            mouth = "июль";
            mouth = "август";
            mouth = "сентябрь";
            mouth = "октябрь";
            mouth = "ноябрь";
            mouth = "декабрь";
            Console.WriteLine("введите месяц ");
            mounth1 = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("введите месяц год");
            year1 = Convert.ToInt32((Console.ReadLine()));
            if (mounth1 == 1 || year1 == 2026)
            {
                Console.WriteLine($"месяц {mouth} в нем 31 день год невискосный");
            }
            else if(mounth1 == 2 || year1 == 2026 )
            {
                Console.WriteLine($"месяц {mouth} в нем 28 день год невискосный");
            }
            else if (mounth1 == 3 || year1 == 2026)
            {
                Console.WriteLine($"месяц {mouth} в нем 31 день год невискосный");
            }
            else if (mounth1 == 4 || year1 == 2026)
            {
                Console.WriteLine($"месяц {mouth} в нем 31 день год невискосный");
            }
            else if (mounth1 == 5 || year1 == 2026)
            {
                Console.WriteLine($"месяц {mouth} в нем 31 день год невискосный");
            }
            else if (mounth1 ==  6|| year1 == 2026)
            {
                Console.WriteLine($"месяц {mouth} в нем 31 день год невискосный");
            }
            else if (mounth1 == 7 || year1 == 2026)
            {
                Console.WriteLine($"месяц {mouth} в нем 31 день год невискосный");
            }
            else if (mounth1 == 8 || year1 == 2026)
            {
                Console.WriteLine($"месяц {mouth} в нем 31 день год невискосный");
            }
            else if (mounth1 == 9 || year1 == 2026)
            {
                Console.WriteLine($"месяц {mouth} в нем 31 день год невискосный");
            }
            else if (mounth1 == 10 || year1 == 2026)
            {
                Console.WriteLine($"месяц {mouth} в нем 31 день год невискосный");
            }
            else if (mounth1 == 11 || year1 == 2026)
            {
                Console.WriteLine($"месяц {mouth} в нем 31 день год невискосный");
            }
            else if (mounth1 == 12 || year1 == 2026)
            {
                Console.WriteLine($"месяц {mouth} в нем 31 день год невискосный");
            }
            else
            {
                Console.WriteLine("вы не ввели месяц год");
            }
        }
    }
}
