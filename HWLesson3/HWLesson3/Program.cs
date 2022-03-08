using System;

namespace HWLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phoneList = {
            {"Иван", "352-56-95"},
            {"Сергей", "578-52-63"},
            {"Роман", "425-54-36"},
            {"Александр", "734-65-23"},
            {"Виталий", "234-67-45"}

            };

            Console.Clear();
            Console.WriteLine("Телефонный справочник");

            for (int i = 0; i < phoneList.GetLength(0); i++)
            {
                for (int j = 0; j < phoneList.GetLength(1); j++)
                {
                    System.Console.Write($"{phoneList[i, j]} ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
