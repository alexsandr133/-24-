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
            char sign;
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

            Interaction.InputBox(
            "введите знак ",
            "добро пожаловать"
            );
            switch(number1)
            {
                case 1:
                sign = '+';
                result = number1 + number2;
                res = $"ваш результат {result}";
                break;

                case 2:
                sign = '-';
                result = number1 - number2;
                res = $"ваш результат {result}";
                break;

                case 3:
                sign = '*';
                result = number1 * number2;
                res = $"ваш результат {result}";
                break;

                case 4:
                sign = '/';
                result = number1 / number2;
                res = $"ваш результат {result}";
                break;

                default:
                 //текси сообщения
                 result = 0;

                 break;
            }
            MessageBox.Show($"ваш результат ," +result+"!");
        }
    }
}
