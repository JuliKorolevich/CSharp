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
            string number = "";
            int sum = 0;

            // обработать строку посимвольно: если не равно пробелу, то к строкеовой переменной number добавляем обрабатываемый символ, если равно, то
            // если number не равен пустой строке, то увеличиваем сумму: считаем сумму, как предыдущая сумма плюс number (number конвертируем в число)
            // иначе - присваем number пустую строку.

            for (int i = 0; i < line.Length; i++)
            {
                char e = line[i];
                if (e != ' ')
                {
                    number = number + e;
                }
                else
                {
                    sum = Sum(number, sum);
                    number = "";
                }
            }
            // вызов метода sum, чтобы прибавить последнее полученное число с помощью цикла for
            sum = Sum(number, sum);

            // вывод суммы в консоль
            Console.WriteLine($"Сумма чисел: {sum}");
        }

        // метод увеличивает сумму путем сложения суммы и числа, полученного из строки путем конвертации строки в число
        static int Sum(string number, int sum)
        {
            if (number != "")
            {
                sum = sum + Convert.ToInt32(number);
            }
            return sum;
        }
    }
}

