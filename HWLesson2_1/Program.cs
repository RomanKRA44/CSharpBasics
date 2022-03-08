using System;

namespace HWLesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string monthTitle = "";
            Console.Write("Введите номер месяца: ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                    monthTitle = "Январь";
                    break;
                case 2:
                    monthTitle = "Февраль";
                    break;
                case 3:
                    monthTitle = "Март";
                    break;
                case 4:
                    monthTitle = "Апрель";
                    break;
                case 5:
                    monthTitle = "Май";
                    break;
                case 6:
                    monthTitle = "Июнь";
                    break;
                case 7:
                    monthTitle = "Июль";
                    break;
                case 8:
                    monthTitle = "Август";
                    break;
                case 9:
                    monthTitle = "Сентябрь";
                    break;
                case 10:
                    monthTitle = "Октябрь";
                    break;
                case 11:
                    monthTitle = "Ноябрь";
                    break;
                case 12:
                    monthTitle = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Укажите значение от 1 до 12");
                    break;
                    
            }
            
            Console.WriteLine(monthTitle);

        }
    }
}
