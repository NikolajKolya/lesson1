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
            int c = 0;
            int a = EnterNumber("а");
            int b = EnterNumber("б");
            while (true)
            {
                bool isSuccess = true;
                Console.WriteLine("Введите операцию: +,-,*,/");

                var enteredOperation = Console.ReadLine();


                switch (enteredOperation)
                {
                    case "+":
                        c = a + b;
                        break;

                    case "-":
                        c = a - b;
                        break;

                    case "*":
                        c = a * b;
                        break;

                    case "/":
                        c = a / b;
                        break;

                    default:
                        Console.WriteLine("Некорректная операция!");
                        isSuccess = false;
                        break;
                }
                if(isSuccess == true)
                {
                    break;
                }
            }

            Console.WriteLine($"Результат: { c }");
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