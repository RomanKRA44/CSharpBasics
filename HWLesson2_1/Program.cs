using System;

namespace HWLesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную температуру за сутки: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальную температуру за сутки: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine((a + b) / 2);
        }
    }
}
