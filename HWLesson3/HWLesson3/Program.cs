using System;

namespace HWLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово:");
            string reverse = Console.ReadLine();
            char[] reversWord = reverse.ToCharArray();
            Array.Reverse(reversWord);
            reverse = new string(reversWord);
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
}
