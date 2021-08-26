using System;

namespace DayOfWeek.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите дату в формате дд.мм.гггг");
            string date = Console.ReadLine();

            Day a = new Day(date);
            a.WriteDayInform();

            Console.ReadKey();
        }
    }
}
