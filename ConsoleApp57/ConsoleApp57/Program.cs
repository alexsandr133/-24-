using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp57

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //переменная для записи товара и его цены
            int min_price_tovar = 399;
            int price_of_tovar;
            int price_of_home = 340;
            string messenge;
            int distance;
            string name_of_tovar;
            min_price_tovar = Int32.Parse(
            Interaction.InputBox(
            "добро пожаловать в интернет магазин",
            "введите цену товара и я рассчитаю вам цену товара",
            "приятных покупок"
            )
            );
            switch (min_price_tovar)
            {
                case 1:
                name_of_tovar = "пульки стайкбольные 6мм";
                price_of_tovar = 700;
                price_of_home = 300;
                int total = price_of_tovar + price_of_home;
                distance = 10;
                break;

                case 2:
                name_of_tovar = "акс 74 страйкбольная cyma cm031d метал сталь платик"; 
                price_of_tovar = 22800;
                price_of_home = 600;
                int total1 = price_of_tovar + price_of_home;
                distance = 20;
                break;

                case 3:
                name_of_tovar = "mp5a1 страйкбольный cyma";
                price_of_tovar = 25900;
                price_of_home = 600;
                int total2 = price_of_home + price_of_tovar + min_price_tovar;
                distance = 20;
                break;

                case 4:
                name_of_tovar = "mp5a1 страйкбольный cyma";
                    price_of_tovar = 1000;
                price_of_home = 600;
                int total3 = price_of_home + price_of_tovar + min_price_tovar;
                distance = 20;
                break;

                default:
                    messenge = "вы ничего не заказади";
                    break;
            }
            MessageBox.Show($"ваш заказ сделан цена заказа {total}");
        }
    }
}
