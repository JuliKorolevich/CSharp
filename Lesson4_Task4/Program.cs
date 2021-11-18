using System;

namespace Lesson4_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // просим ввести номер последовательности числа Фибоначчи, которое хотим получить
            Console.Write("Введите номер числа Фибоначчи: ");
            string fib = Console.ReadLine();
            int fibNumber = Convert.ToInt32(fib);

            // задаем первые два числа в последовательности Фибоначчи 0 и 1
            int previousFibNumber = 2;
            int firstNumber = 0;
            int secondNumber = 1;

            // проверяем, что указанное пользователем число больше 0, в противном случае выдаем ошибку
            if (fibNumber > 0)
            {
                int number = GetFibonacci(firstNumber, secondNumber, fibNumber, previousFibNumber);
                Console.WriteLine($"Число Фибоначчи: {number}");
            }
            else
            {
                Console.WriteLine($"Число должно быть больше 0.");
            }

        }

        // метод расчета числа фибоначчи на основании предыдущего числа последовательноти, текущего, запрашиваемого номера последовательности Фибоначчи
        // пользователем, а также номера последовательности предыдущего обработанного числа Фибоначчи
        static int GetFibonacci(int previousNumber, int currentNumber, int fibNumber, int previousFibNumber)
        {
            int nextNumber;
            if (previousFibNumber < fibNumber)
            {
                nextNumber = previousNumber + currentNumber;
                previousFibNumber = previousFibNumber + 1;
                return GetFibonacci(currentNumber, nextNumber, fibNumber, previousFibNumber);
            }
            if (fibNumber == 1)
            {
                return previousNumber;
            }
            else
            {
                return currentNumber;
            }
        }
    }
}
