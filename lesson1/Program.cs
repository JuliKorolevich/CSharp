using System;

namespace Lesson1
{
    /// <summary>
    /// Описание класса
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        /* запрос имени пользователя и отображение текущей даты после ввода имени
          без проверок, что пользователь заполнил имя */
        {
            Console.Write("Добрый день! Введите Ваше имя, пожалуйста: ");
            var userName = Console.ReadLine();
            DateTime todayDate = DateTime.Today;
            Console.WriteLine($"Привет, {userName}, сегодня {todayDate.ToShortDateString()}г.");
        }
    }
}