using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //переменная для записи чисел
            int number1;
            int number2;
            int result;
            string res;
            //запись знака
            int choise;
            Char sign;
            //обработка числаэ
            number1 = Int32.Parse(
            Interaction.InputBox(
            "введите число ",
            "добро пожаловать"
            )
            );
            number2 = Int32.Parse(
            Interaction.InputBox(
            "введите число ",
            "добро пожаловать"
            )
            );

            //знак по умолчанию
            choise = Int32.Parse(
             Interaction.InputBox(
            "введите номер операции которую хотите ",
            "добро пожаловать"
            )
            );
            char sign1;


            switch (choise)
            {
                case 1:
                choise = 1;
                sign = '+';
                result = number1 + number2;
                res = $"ваш результат {result}";
                break;

                case 2:
                choise = 1;
                sign = '-';
                result = number1 - number2;
                res = $"ваш результат {result}";
                break;

                case 3:
                choise = 1;
                sign = '*';
                result = number1 * number2;
                res = $"ваш результат {result}";
                break;

                case 4:
                choise = 1;
                sign = '/';
                result = number1 / number2;
                res = $"ваш результат {result}";
                break;

                default:
                 //текси сообщения
                 res = "вы не ввели данные числа и знак";
                 break;
            }
            MessageBox.Show($"ваш результат {res}");
           
        }
    }
}
