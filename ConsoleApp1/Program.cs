using System;

// Калькулятор

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double a; double b;
                try
                {
                    Console.Write("Введите 1 число: ");
                    a = double.Parse(Console.ReadLine());

                    Console.Write("Введите 2 число: ");
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Нужно вводить число!");
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Напишите операнд: ");
                string c = Console.ReadLine();

                switch (c)
                {
                    case "+":
                        Console.WriteLine($"Ответ: {a + b}");
                        break;

                    case "-":
                        Console.WriteLine($"Ответ: {a - b}");
                        break;

                    case "*":
                        if (b == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine($"Ответ: {a * b}");
                        }
                        break;

                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine($"Ответ: {a / b}");
                        }
                        break;

                    case "%":
                        if (b == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine($"Ответ: {a % b}");
                        }
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
