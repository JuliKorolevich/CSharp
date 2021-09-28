using System;

namespace Lesson2_Task4
{
    class Program
    {
        enum products
        {
            Молоко,
            Хлеб,
            Колбаса
        }

        static void Main(string[] args)
        {

            /* объявление переменных и добавления к ним статичных значений для вывода в чек */

            int checkNumber = 11111;
            string accountName = "ООО Ромашка";
            int tin = 123456789;
            string address = "770000, Москва, Рязанский пр-т, 12";
            DateTime createdDate = DateTime.Now;
            double milkPrice = 70.00;
            double breadPrice = 50.00;
            double sausagePrice = 500.00;
            int milkAmount = 1;
            int breadAmount = 4;
            int sausageAmount = 2;
            double milkCost;
            milkCost = milkAmount * milkPrice;
            double breadCost;
            breadCost = breadAmount * breadPrice;
            double sausageCost;
            sausageCost = sausageAmount * sausagePrice;
            double totalCost;
            totalCost = milkCost + breadCost + sausageCost;



            /* вывод данных чека на экран */

            Console.WriteLine($"--------------------------------------------");
            Console.WriteLine($"|                  {checkNumber}                   |");
            Console.WriteLine($"|               {accountName}                |");
            Console.WriteLine($"|              ИНН {tin}               |");
            Console.WriteLine($"| Адрес {address} |");
            Console.WriteLine($"|            {createdDate}           |");
            Console.WriteLine($"|******************************************|");
            Console.WriteLine($"|    Товар      Цена    Кол-во   Ст-ть     |");
            Console.WriteLine($"|   {products.Молоко}       {milkPrice}        {milkAmount}       {milkCost}      |");
            Console.WriteLine($"|   {products.Хлеб}         {breadPrice}        {breadAmount}       {breadCost}     |");
            Console.WriteLine($"|   {products.Колбаса}      {sausagePrice}       {sausageAmount}       {sausageCost}    |");
            Console.WriteLine($"|******************************************|");
            Console.WriteLine($"|               Итог: {totalCost}                 |");
            Console.WriteLine($"--------------------------------------------");

        }
    }
}
