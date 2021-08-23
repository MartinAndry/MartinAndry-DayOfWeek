using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
        { 
            //Console.WriteLine("введите дату в формате дд.мм.гггг");
            //string date = Console.ReadLine();

            //int day = Convert.ToInt32(date.Substring(0, 2));
            //int month = Convert.ToInt32(date.Substring(3, 2));
            //int year = Convert.ToInt32(date.Substring(6, 4));

            //int[] monthArr = new[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30 };

            //int days = 0;
            //int days29 = 0;
            //int leap = 0;

            //if (year % 4 == 0 && year != 4)
            //{
            //    if (year != 1700 && year != 1800 && year != 1900 && year != 2100 && year != 2200 && year != 2300)
            //    {
            //        leap++;
            //    }
            //}

            //if (year < 7)
            //{
            //    //days29 = (year - 1) / 4 + (year - 1) * 365;
            //    days29 = 0;

            //}

            //if (year <= 1700 && year > 6)
            //{
            //    //days29 = (year - 1) / 4 - 1 + (year - 1) * 365;
            //    days29 = (year - 1) / 4 - 1;
            //}

            //if (year > 1700)
            //{
            //    days29 = (year - 1) / 4 - (year - 1700) / 100 + (year - 1600) / 400 - 1;
            //}

            //days = (year - 1) * 365 + days29;

            //for (int i = 0; i < month - 1; i++)
            //{
            //    days = days + monthArr[i];
            //}

            //if (month > 2 && leap == 1)
            //{
            //    days++;
            //}

            //days = days + day;

            //int dayOfWeek = days % 7;

            //switch (dayOfWeek)
            //{
            //    case 0:
            //        Console.WriteLine($"{date} вторник");
            //        break;
            //    case 1:
            //        Console.WriteLine($"{date} среда");
            //        break;
            //    case 2:
            //        Console.WriteLine($"{date} четверг");
            //        break;
            //    case 3:
            //        Console.WriteLine($"{date} пятница");
            //        break;
            //    case 4:
            //        Console.WriteLine($"{date} суббота");
            //        break;
            //    case 5:
            //        Console.WriteLine($"{date} воскресенье");
            //        break;
            //    case 6:
            //        Console.WriteLine($"{date} понедельник");
            //        break;
            //    default:
            //        break;
            //}

            //if (leap == 1)
            //{
            //    Console.WriteLine("Год был высокостный");
            //}
            //else
            //{
            //    Console.WriteLine("Год был не высокостный");
            //}
        }
            Learning.Date();
            Console.ReadKey();
        }
    }
}




