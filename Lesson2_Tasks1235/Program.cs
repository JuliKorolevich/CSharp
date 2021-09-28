using System;

namespace Lesson2_Tasks1235
{
    class Program
    {
        // список месяцев

        enum Months
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }

        static void Main(string[] args)
        {
            /* запрос у пользователя минимальной и максимальной температуры за сутки, 
             * расчет средней температуры */

            Console.Write("Укажите минимальную температуру за текущие сутки: ");
            int minTemperature = int.Parse(Console.ReadLine());
            Console.Write("Укажите максимальную температуру за текущие сутки: ");
            int maxTemperature = int.Parse(Console.ReadLine());
            double AverageTemperature;
            if (minTemperature > maxTemperature)
            {
                Console.WriteLine("Минимальная температура не может быть больше максимальной.");
                return;
            }
            else
            {
                AverageTemperature = (minTemperature + maxTemperature) / 2.0;
                Console.WriteLine($"Средняя температура {AverageTemperature}");
            }

            /* запрос у пользователя порядкового номера текущего месяца для определения названия текущего месяца,
             * а также для определения, является ли месяц четным / нечетным */

            Console.Write("Введите порядковый номер текущего месяца: ");
            int currentMonthNumber = int.Parse(Console.ReadLine());
            Months currentMonth = (Months)Enum.ToObject(typeof(Months), currentMonthNumber);
            double EvenMonth = currentMonthNumber % 2;
            if (EvenMonth == 0)
            {
                Console.WriteLine($"Месяц четный. Текущий месяц: {currentMonth}");
            }
            else
            {
                Console.WriteLine($"Месяц нечетный. Текущий месяц: {currentMonth}");
            }

            /* если средняя температура за сутки больше нуля, а месяц зимний, то вернуть сообщение "Дождливая зима" */

            if (AverageTemperature > 0 && (currentMonthNumber == 1 || currentMonthNumber == 2 || currentMonthNumber == 12))
            {
                Console.WriteLine("Дождливая зима");
            }
            else
            {
                return;
            }
        }
    }
}
