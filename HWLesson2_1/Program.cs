using System;

namespace HWLesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Число: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0) Console.WriteLine("Число четное");
            else
                Console.WriteLine("Чило не четное");

        }
    }
}
