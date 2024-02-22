//Задание 1: Напишите программу, которая принимает на вход 
//число и проверяет, кратно ли оно одновременно 7 и 23.


//using System;

//class Program
//{
    //static void Main(string[] args)
    //{
        //Console.WriteLine("Введите число для проверки:");
        //string input = Console.ReadLine();
        
        //int number;
        //if (int.TryParse(input, out number))
        //{
            //if (number % 7 == 0 && number % 23 == 0)
            //{
                //Console.WriteLine("Число кратно и 7, и 23.");
            //}
            //else
            //{
                //Console.WriteLine("Число не кратно одновременно 7 и 23.");
            //}
        //}
        //else
        //{
            //Console.WriteLine("Ошибка: Введите целое число.");
        //}
    //}
//}


//Задание 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер
//координатной четверти плоскости, в которой находится эта точка.


//using System;

//class Program
//{
    //static void Main(string[] args)
    //{
        //Console.WriteLine("Введите координаты точки (X и Y):");

        //Console.Write("X = ");
        //double x = double.Parse(Console.ReadLine());

        //Console.Write("Y = ");
        //double y = double.Parse(Console.ReadLine());

        //if (x > 0 && y > 0)
        //{
            //Console.WriteLine("Точка находится в первой координатной четверти.");
        //}
        //else if (x < 0 && y > 0)
        //{
            //Console.WriteLine("Точка находится во второй координатной четверти.");
        //}
        //else if (x < 0 && y < 0)
        //{
            //Console.WriteLine("Точка находится в третьей координатной четверти.");
        //}
        //else if (x > 0 && y < 0)
        //{
            //Console.WriteLine("Точка находится в четвёртой координатной четверти.");
        //}
        //else
        //{
           // Console.WriteLine("Точка не принадлежит ни одной из координатных четвертей.");
        //}
    //}
//}



// Задание 3. Напишите программу, которая на вход принимает целое число из отрезка [10,99]
//и показывает наибольшую цифру числа.

//using System;

//class MainClass {
    //public static void Main (string[] args) {
        //Console.WriteLine("Введите целое число от 10 до 99:");
        //int number = int.Parse(Console.ReadLine());

        //if (number < 10 || number > 99) {
            //Console.WriteLine("Число должно быть из отрезка [10, 99]");
        //}
        //else {
            //int firstDigit = number / 10;
            //int secondDigit = number % 10;

            //int maxDigit = Math.Max(firstDigit, secondDigit);

            //Console.WriteLine($"Наибольшая цифра числа {number} - {maxDigit}");
       // }
   // }
//}

// Задание 4. Напишите программу, которая на вход принимает натуральное
//число N, а на выходе показывает его цифры через запятую.



using System;
class Program
{
static void Main()
{
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
Console.WriteLine(N);
}
else
{
while (N > 0)
{
int currentDigit = N % 10;
N /= 10;
if (N > 0)
{
Console.Write(currentDigit + ",");
}
else
{
Console.WriteLine(currentDigit);
}
}
}
}
}