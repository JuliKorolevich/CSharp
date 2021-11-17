using System;

namespace Lesson4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // вызов методов по запросу имени, фамилии, отчества, а также по формированию ФИО (3 раза)
            string name1 = GetfirstName();
            string lastname1 = Getlastname();
            string patronymic1 = Getpatronymic();
            string fullname1 = GetfullName(name1, lastname1, patronymic1);
            Console.WriteLine($"ФИО1: {fullname1}");
            string name2 = GetfirstName();
            string lastname2 = Getlastname();
            string patronymic2 = Getpatronymic();
            string fullname2 = GetfullName(name2, lastname2, patronymic2);
            Console.WriteLine($"ФИО2: {fullname2}");
            string name3 = GetfirstName();
            string lastname3 = Getlastname();
            string patronymic3 = Getpatronymic();
            string fullname3 = GetfullName(name3, lastname3, patronymic3);
            Console.WriteLine($"ФИО3: {fullname3}");
        }
         // метод запрашивает у пользователя и возвращает имя
       static string GetfirstName()
        {
            Console.Write("Введите имя: ");
            string firstname = Console.ReadLine();
            return firstname;
        }

        // метод запрашивает у пользователя и возвращает фамилию
        static string Getlastname()
        {
            Console.Write("Введите фамилию: ");
            string lastname = Console.ReadLine();
            return lastname;
        }

        // метод запрашивает у пользователя и возвращает отчество
        static string Getpatronymic()
        {
            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine();
            return patronymic;
        }

        // метод формирует и возвращает полное имя (фамилия + имя + отчество)
        static string GetfullName(string firstName, string lastName, string patronymic)
        {
            string fullName = firstName + " " + lastName + " " + patronymic;
            return fullName;
        }
        

    }
}
