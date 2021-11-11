using System;

namespace Lesson4_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // запрос ввода чисел через пробел, формирование массива значений, где разделитель - пробел
            Console.Write("Введите числа через пробел: ");
            string line = Console.ReadLine();
            string[] numbersByLine = line.Split(' ');

            // преобразование строкового массива в целочисленный
            int[] numbers = new int[numbersByLine.Length];

            for (int i = 0; i < numbersByLine.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numbersByLine[i]);
            }

            // подсчет суммы значений элементов массива numbers и вывод на экран пользователю
            int sum;
            sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine($"Сумма чисел: {sum}");

            /* вывод последовательно каждого элемента массива numbers
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number}");
            }  */
        }
    }
}
