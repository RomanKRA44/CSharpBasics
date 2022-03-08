using System;

namespace HWLesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateAndTime = new DateTime(2021, 8, 31, 17, 05, 23);
            Console.WriteLine(dateAndTime); // 04.08.2015 16:23:42

            string name_l = "ПАО СБЕРБАНК";
            string name_r = "Сверка итогов";
            string name_l1 = "Терминал:";
            int x = 23301367;
            string name_l2 = "Мерчант:";
            int y = 551000117;
            string name_l3 = "Итоги совпали:";
            string name_l4 = "Валюта:";
            string name_r1 = "Руб.";
            string name_l5 = "Оплата";
            string name_l6 = "Всего операций:";
            int z = 4;
            string name_l7 = "на сумму:";
            double a = 6000.00;
            string name_l8 = "Скидка:";
            double b = 0.00;
            string name_l9 = "Отчет закончен:";

            Console.WriteLine(name_l + " " + name_r);
            Console.WriteLine(name_l1 + " " + x);
            Console.WriteLine(name_l2 + " " + y);
            Console.WriteLine(" ");
            Console.WriteLine(name_l3);
            Console.WriteLine(name_l4 + " " + name_r1);
            Console.WriteLine(name_l5);
            Console.WriteLine(name_l6 + " " + z);
            Console.WriteLine(name_l7 + " " + a);
            Console.WriteLine(name_l8 + " " + b);
            Console.WriteLine(" ");
            Console.WriteLine("*******" + name_l9 + "*******");
            Console.WriteLine("*****************************");

        }
    }
}
