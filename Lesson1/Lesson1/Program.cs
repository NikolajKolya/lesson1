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
            int temporary = 0;
            double c = 0;
            string resultMessage = "";
            int a = EnterNumber("а");
            int b = EnterNumber("б");
            while (true)
            {
                bool isSuccess = true;
                Console.WriteLine("Введите операцию: +,-,*,/,i,p");

                var enteredOperation = Console.ReadLine();

                switch (enteredOperation)
                {
                    case "+":
                        resultMessage = "сложенија";
                        c = a + b;
                        break;

                    case "-":
                        resultMessage = "вичитанија";
                        c = a - b;
                        break;

                    case "*":
                        resultMessage = "умноженија";
                        c = a * b;
                        break;

                    case "/":
                        resultMessage = "деленија";

                        try
                        {
                            c = a / (double)b;
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                            Environment.Exit(1);
                        }
                        
                        break;
                    case "i":
                        while (true)
                        {
                            if (b > 0)
                            {
                                temporary += b % 10;
                                b = b / 10;
                            }
                            else if (a > 0)
                            {
                                temporary += a % 10;
                                a = a / 10;
                            }
                            else
                            {
                                break;
                            }
                        }
                        c = temporary;
                        resultMessage = "сложенија цифр чисел";
                        break;
                    case "p":
                         c = Math.Sqrt(a*a+b*b);
                        resultMessage = "diagonalj";
                        break;

                    default:
                        Console.WriteLine("Некорректная операция!");
                        isSuccess = false;
                        break;
                }

                if (isSuccess)
                {
                    break;
                }
            }

            Console.WriteLine($"Результат { resultMessage }: { c }");
            Console.ReadLine();
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