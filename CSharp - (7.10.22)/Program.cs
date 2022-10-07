using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp____7._10._22_
{
    public class myDate
    {
        public int year
        {
            get { return year; }
            set
            {
                if (value >= 1970)
                {
                    year = value;
                }
                else
                {
                    year = 1970;
                }
            }
        }
        public int month
        {
            get { return month; }
            set
            {
                if (value > 0 | value <= 12)
                {
                    month = value;
                }
                else
                {
                    month = 1;
                }
            }
        }
        public int day
        {
            get { return day; }
            set
            {
                if (value > 0 | value <= DayOfMonthArr.month[this.month - 1])
                {
                    day = value;
                }
                else
                {
                    day = 1;
                }
            }
        }
        public void Print()
        {
            Console.WriteLine($"{this.year}.{this.month}.{this.day}");
        }
    }
    internal class Program
    {
        //static void f01()
        //{
        //    //string[] dayOfWeek = new string[] 
        //    //{"Monday", "Tuesday", "Wednesday", 
        //    // "Thursday", "Friday", "Saturday", "Sunday" };

        //    //for(var i = DayOfWeek.Monday; i <= DayOfWeek.Sunday; i++)
        //    //{
        //    //    Console.WriteLine(i);

        //    //}
        //    foreach (var item in Enum.GetValues(typeof(DayOfWeek)))
        //    {
        //        Console.WriteLine($"Перечисления через Enum.GetValues {0}", item);
        //    }
        //    foreach (var item in Enum.GetValues(typeof(DayOfWeek)))
        //    {
        //        DetectDay((DayOfWeek)item);
        //    }
        //    foreach (var item in Enum.GetValues(typeof(DayOfMonthsRus)))
        //    {
        //        Console.WriteLine("В месяце {0} {1}", item.ToString(), DayOfMonthArr.month[(int)item] + " дней");
        //    }
        //    Console.WriteLine("{0} = {1}", DayOfMonthsRus.Август, (int)DayOfMonthsRus.Август);
        //}
        //static void DetectDay (string _day)
        //{
        //    if (_day != "Saturday" & _day != "Sunday")
        //    {
        //        Console.WriteLine($"This day {_day} is working");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"This day {_day} is weekend");
        //    }
        //}

        //static void DetectDay(DayOfWeek _day)
        //{
        //    if (_day != DayOfWeek.Saturday & _day != DayOfWeek.Sunday)
        //    {
        //        Console.WriteLine($"This day {_day} is working");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"This day {_day} is weekend");
        //    }
        //}

        static bool LeapYear()
        {
            bool _result = true;
            return _result;
        }
        static void Main(string[] args)
        {
            int starDay = 3; //1970.1.1 day of week
                             //2022.10.07
            var date = new myDate();
            try 
            {
                date.year = int.Parse(args[0].Split('.')[0]);
                date.month = int.Parse(args[0].Split('.')[1]);
                date.day = int.Parse(args[0].Split('.')[2]);        
            }
            catch
            {
                Console.WriteLine("Something wrong");
            }
           date.Print();
            Console.ReadKey();
        }
    }
}
