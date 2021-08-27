using System;
using System.Collections.Generic;
using System.Text;

namespace DayOfWeek.App
{
    class Day
    {
        string date;
        bool isLeap;
        int[] monthArr;
        int leapDays;
        int days;
        int day;
        int month;
        int year;
        bool isValidData = true;


        public Day(string sDate)
        {
            Initialization(sDate);
        }

        private void Initialization(string sDate)
        {

            if (!IsValidInput(sDate))
            {
                isValidData = false;
            }

            monthArr = new[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            date = sDate;
            day = Convert.ToInt32(sDate.Substring(0, 2));
            month = Convert.ToInt32(sDate.Substring(3, 2));
            year = Convert.ToInt32(sDate.Substring(6, 4));

            isLeap = CalculateLeap();
            if (!IsValidDate())
            {
                isValidData = false;
            }

            leapDays = CalculateLeapDays29();
            days = CalculateDays();

        }

        private bool IsValidInput(string sDate)
        {
            if (sDate.Length != 10)
            {
                Console.WriteLine("дата указанна не правильно");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CalculateLeap()
        {
            if (year % 4 == 0 && year != 4)
            {
                if (year != 1700 && year != 1800 && year != 1900 && year != 2100 && year != 2200 && year != 2300)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsValidDate()
        {
            
            try
            {
                if (day == 29 && month == 2 && !isLeap)
                {
                    Console.WriteLine("в этом году нет 29.02");
                    return false;
                }
                else if (day > monthArr[month - 1])
                {
                    if (day == 29 && month == 2 && isLeap)
                    {
                        Console.WriteLine("Бонусный день!!!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("в этом месяце меньше дней");
                        return false;
                    }
                }
                else if (month > 12)
                {
                    Console.WriteLine("13го месяца не бывает");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("data invalid");
            }
            return false;
        }

        private int CalculateLeapDays29()
        {
            if (year < 7)
            {
                return 0;
            }

            else if (year <= 1700 && year > 6)
            {
                return (year - 1) / 4 - 1;
            }

            else
            {
                return (year - 1) / 4 - (year - 1700) / 100 + (year - 1600) / 400 - 1;
            }
        }

        private int CalculateDays()
        {
            int result;
            result = (year - 1) * 365 + leapDays;

            // добавляем прошедшие месяца
            for (int i = 0; i < month - 1; i++)
            {
                result += monthArr[i];
            }

            // добавляем прошедший 29ый день
            if (month > 2 && isLeap)
            {
                result++;
            }

            // добавляем прошедшие дни
            result += day;
            return result;
        }

        public void WriteDayInform()
        {
            if (isValidData)
            {
                EnumDaysOfWeek dayOfWeek = (EnumDaysOfWeek)(days % 7);

                // перебор + вывод дня
                switch (dayOfWeek)
                {
                    case EnumDaysOfWeek.tuesday:
                        Console.WriteLine($"{date} вторник");
                        break;
                    case EnumDaysOfWeek.wednesday:
                        Console.WriteLine($"{date} среда");
                        break;
                    case EnumDaysOfWeek.thuesday:
                        Console.WriteLine($"{date} четверг");
                        break;
                    case EnumDaysOfWeek.friday:
                        Console.WriteLine($"{date} пятница");
                        break;
                    case EnumDaysOfWeek.sunday:
                        Console.WriteLine($"{date} суббота");
                        break;
                    case EnumDaysOfWeek.saturday:
                        Console.WriteLine($"{date} воскресенье");
                        break;
                    case EnumDaysOfWeek.monday:
                        Console.WriteLine($"{date} понедельник");
                        break;
                }

                // вывод "высокостный?"
                if (isLeap)
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
}

