using System;

namespace Lesson4_Task3
{
    class Program
    {
        enum Seasons
        {
            // времена года.
            Winter = 1,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            // вызов метода запроса номера месяца, вызов метода получения значения справочника Seasons, вызов метода
            // получения названия времени года на русском языке, вывод названия времени года на экран
            int currentMonthNumber = CurrentMonthNumber();
            Seasons seasonEng = CurrentSeasonName(currentMonthNumber);
            string seasonRusName = CurrentSeasonRusName(seasonEng);
            Console.WriteLine(seasonRusName);

        }
         // метод запрашивает и возвращает порядковый номер текущего месяца
        static int CurrentMonthNumber()
        {
            Console.Write("Введите порядковый номер текущего месяца: ");
            int currentMonthNumber = int.Parse(Console.ReadLine());
            return currentMonthNumber;
        }

        /* метод получает на вход число (номер месяца), в случае, если номер не входит в промежуток 1-12,
         * вызывает метод запроса номера текущего месяца, а затем текущий метод повторно.
         * В случае, если число входит в промежуток 1-12, то возвращает значение списка Seasons в зависимости от числа месяца */
        static Seasons CurrentSeasonName(int MonthNumber)
        {
            if (MonthNumber >= 1 && MonthNumber <= 12)
            {
                Seasons season;
                if (MonthNumber >= 3 && MonthNumber <= 5)
                {
                    season = Seasons.Spring;
                    return season;
                }
                if (MonthNumber >= 6 && MonthNumber <= 8)
                {
                    season = Seasons.Summer;
                    return season;
                }
                if (MonthNumber >= 9 && MonthNumber <= 11)
                {
                    season = Seasons.Autumn;
                    return season;
                }
                else
                {
                    season = Seasons.Winter;
                    return season;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                int month = CurrentMonthNumber();
                return CurrentSeasonName(month);
            }
        }

        // метод получает на вход справочное значение Seasons, возвращает название времени года на русском языке
        static string CurrentSeasonRusName(Seasons MonthNumber)
            {
                string currentSeasonRusName;
                if (MonthNumber == Seasons.Winter)
                {
                    currentSeasonRusName = "Зима";
                    return currentSeasonRusName;
                }
                if (MonthNumber == Seasons.Spring)
                {
                    currentSeasonRusName = "Весна";
                    return currentSeasonRusName;
                }
                if (MonthNumber == Seasons.Summer)
                {
                    currentSeasonRusName = "Лето";
                    return currentSeasonRusName;
                }
                else
                {
                    currentSeasonRusName = "Осень";
                    return currentSeasonRusName;
                }
            }
    }
}
