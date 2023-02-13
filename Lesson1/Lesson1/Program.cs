﻿// Пространство имён
namespace Lesson1
{
    /// <summary>
    /// Главный класс - Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа - метод, исполняемый при запуске программы.
        /// Он всегда называется Main
        /// </summary>
        static void Main(string[] args)
        {
            int a = EnterNumber("а");
            int b = EnterNumber("б");

            int c = a + b;

            Console.WriteLine($"{ a } + { b } = { c }");
        }

        /// <summary>
        /// Метод, вводящий число с клавиатуры
        /// </summary>
        /// <returns>Введённое число</returns>
        static int EnterNumber(string g)
        {
            Console.WriteLine($"Введите число { g }:");
            string enteredString = Console.ReadLine();
            return int.Parse(enteredString);
        }
    }
}