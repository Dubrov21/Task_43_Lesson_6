//Написать программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
//y = k1 * x +b1; y = k2 * x + b2; значения b1, k1, b2, k2 задаются пользователем

using System;

namespace Task_43_Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Введите значение b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение k1: ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение k2: ");
            double k2 = Convert.ToDouble(Console.ReadLine());

            double x = -(b1 - b2) / (k1 - k2);
            double y = k1 * x + b1;

            Console.Write($"Точка пересечения двух прямых: [{x}, {y}]");
        }
    }
}
