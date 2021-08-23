using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Learning
    {
        /// <summary>
        /// счет времени по сек с вводом
        /// </summary>
        public static void Time(int sec)
        {
            int hour = sec / 3600;
            int min = (sec - hour * 3600) / 60;
            int sec2 = sec - hour * 3600 - min * 60;

            if (hour < 10)
            {
                Console.Write("0");
            }
            Console.Write(hour + ":");

            if (min < 10)
            {
                Console.Write("0");
            }
            Console.Write(min + ":");


            if (sec2 < 10)
            {
                Console.Write("0");
            }
            Console.Write(sec2);
        }
        /// <summary>
        /// счет времени по сек без ввода
        /// </summary>
        public static void Time()
        {
            Console.WriteLine("vvedite sec");
            int sec = Convert.ToInt32(Console.ReadLine());

            int hour = sec / 3600;
            int min = (sec - hour * 3600) / 60;
            int sec2 = sec - hour * 3600 - min * 60;

            if (hour < 10)
            {
                Console.Write("0");
            }
            Console.Write(hour + ":");

            if (min < 10)
            {
                Console.Write("0");
            }
            Console.Write(min + ":");


            if (sec2 < 10)
            {
                Console.Write("0");
            }
            Console.Write(sec2);
        }
        //public static void Days()
        //{
        //    Console.WriteLine("Введите сторону 1 прямоугольника материала");
        //    int H = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Введите сторону 2 прямоугольника материала");
        //    int W = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Введите сторону 1 прямоугольника");
        //    int h = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Введите сторону 2 прямоугольника");
        //    int w = Convert.ToInt32(Console.ReadLine());



        //}
        public static void Date()
        {
            // ввод даты
            Console.WriteLine("введите дату в формате дд.мм.гггг");
            string date = Console.ReadLine();

            // инициализация
            int day = Convert.ToInt32(date.Substring(0, 2));
            int month = Convert.ToInt32(date.Substring(3, 2));
            int year = Convert.ToInt32(date.Substring(6, 4));

            int[] monthArr = new[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30 };

            int days = 0;
            int days29 = 0;
            int leap = 0;

            // текущий год высокостный?
            if (year % 4 == 0 && year != 4)
            {
                if (year != 1700 && year != 1800 && year != 1900 && year != 2100 && year != 2200 && year != 2300)
                {
                    leap++;
                }
            }

            // счет дней в прошедших годах
            if (year < 7)
            {
                days29 = 0;
            }

            if (year <= 1700 && year > 6)
            {
                days29 = (year - 1) / 4 - 1;
            }

            if (year > 1700)
            {
                days29 = (year - 1) / 4 - (year - 1700) / 100 + (year - 1600) / 400 - 1;
            }

            days = (year - 1) * 365 + days29;

            // добавляем прошедшие месяца
            for (int i = 0; i < month - 1; i++)
            {
                days = days + monthArr[i];
            }

            // добавляем прошедший 29ый день
            if (month > 2 && leap == 1)
            {
                days++;
            }

            // добавляем прошедшие дни
            days = days + day;

            // счет дня
            int dayOfWeek = days % 7;

            // перебор + вывод дня
            switch (dayOfWeek)
            {
                case 0:
                    Console.WriteLine($"{date} вторник");
                    break;
                case 1:
                    Console.WriteLine($"{date} среда");
                    break;
                case 2:
                    Console.WriteLine($"{date} четверг");
                    break;
                case 3:
                    Console.WriteLine($"{date} пятница");
                    break;
                case 4:
                    Console.WriteLine($"{date} суббота");
                    break;
                case 5:
                    Console.WriteLine($"{date} воскресенье");
                    break;
                case 6:
                    Console.WriteLine($"{date} понедельник");
                    break;
                default:
                    break;
            }

            // вывод "высокостный?"
            if (leap == 1)
            {
                Console.WriteLine("Год был высокостный");
            }
            else
            {
                Console.WriteLine("Год был не высокостный");
            }
        }
    }
}
