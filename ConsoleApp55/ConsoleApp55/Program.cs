using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("привествую вас пользователь");
            Console.WriteLine("введите возраст");
            int age;
            int price = 500;
            int skidka = price * 100 / 20;
            int skidka1 = price * 100 / 10;
            int res = skidka + skidka1;
            string day;
            day = Console.ReadLine();
            int result;
            age = Convert.ToInt32(Console.ReadLine());
            if (age == 18 && age == 65)
            {
                Console.WriteLine($"ваш билет со скидкой {skidka} и билет {price} ");
            }
            else if (day == "monday" && day == "wensday" )
            {
                Console.WriteLine($"ваша скидка по дням {res} и билет {price}");
            }
            else if(age == 7)
            {
                Console.WriteLine("у вас билет бесплатный");
            }
            else
            {
                Console.WriteLine("введите данные");
            }
        }
    }
}
