//Задание 1: Напишите программу, которая принимает на вход 
//число и проверяет, кратно ли оно одновременно 7 и 23.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число для проверки:");
        string input = Console.ReadLine();
        
        int number;
        if (int.TryParse(input, out number))
        {
            if (number % 7 == 0 && number % 23 == 0)
            {
                Console.WriteLine("Число кратно и 7, и 23.");
            }
            else
            {
                Console.WriteLine("Число не кратно одновременно 7 и 23.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введите целое число.");
        }
    }
}
