using System;

namespace Lesson2_Task6
{
    class Program
    {
        [Flags]
        public enum WeekDays
        {
            // Дни недели.
            Monday = 0b_0000001,
            Tuesday = 0b_000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000,
        }
        static void Main(string[] args)
        {
            WeekDays firstBranch = (WeekDays)0b_1111111;
            Console.WriteLine($"Дни работы первого офиса: {firstBranch}");
            WeekDays secondBranch = (WeekDays)0b_0011111;
            Console.WriteLine($"Дни работы второго офиса: {secondBranch}");
        }
}
}
