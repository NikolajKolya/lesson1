// Пространство имён
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
            while(true)
            {
                Console.WriteLine($"Введите число {g}:");
                string enteredString = Console.ReadLine();

                int result = 0;
                bool isSuccess = int.TryParse(enteredString, out result);

                if (isSuccess)
                {
                    return result;
                }

                Console.WriteLine("Вы ввели не число!");
            }
        }
    }
}