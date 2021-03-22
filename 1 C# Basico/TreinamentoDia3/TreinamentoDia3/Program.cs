using System;
using System.Globalization;
using System.Collections.Generic;

namespace TreinamentoDia3
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------var----------------------

            //var x = 10;
            //var y = 20.0;
            //var z = "Maria";

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //----------------------switch-case----------------------

            //int x = int.Parse(Console.ReadLine());
            //string day;

            //switch(x)
            //{
            //    case 1:
            //        day = "Sunday";
            //        break;
            //    case 2:
            //        day = "Monday";
            //        break;
            //    case 3:
            //        day = "Tuesday";
            //        break;
            //    case 4:
            //        day = "Wednesday";
            //        break;
            //    case 5:
            //        day = "Thursday";
            //        break;
            //    case 6:
            //        day = "Friday";
            //        break;
            //    case 7:
            //        day = "Saturday";
            //        break;
            //    default:
            //        day = "Invalid value";
            //        break;
            //}

            //Console.WriteLine("Day: " + day);

            //----------------------Condicional ternária----------------------

            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ////                (  condição  )    verdadeiro :    falso
            //double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            //Console.WriteLine(desconto);

            //----------------------Funções para string----------------------

            //string original = "abcde FGHIJ ABC abc DEFG     ";
            //string s1 = original.ToUpper();
            //string s2 = original.ToLower();
            //string s3 = original.Trim();

            //int n1 = original.IndexOf("bc");
            //int n2 = original.LastIndexOf("bc");

            //string s4 = original.Substring(3);
            //string s5 = original.Substring(3, 5);

            //string s6 = original.Replace('a', 'x');
            //string s7 = original.Replace("abc", "xy");

            //bool b1 = String.IsNullOrEmpty(original);
            //bool b2 = String.IsNullOrWhiteSpace(original);

            //Console.WriteLine("Original: -" + original + "-");
            //Console.WriteLine("ToUpper: -" + s1 + "-");
            //Console.WriteLine("ToLower: -" + s2 + "-");
            //Console.WriteLine("Trim: -" + s3 + "-");

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("IndexOf('bc'): " + n1);
            //Console.WriteLine("LastIndexOf('bc'): " + n2);

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("Substring(3): -" + s4 + "-");
            //Console.WriteLine("Substring(3, 5): -" + s5 + "-");

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            //Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("IsNullOrEmpty: " + b1);
            //Console.WriteLine("IsNullOrWhiteSpace: " + b2);

            //----------------------DateTime----------------------

            //DateTime d1 = new DateTime(2018, 11, 5);
            //DateTime d2 = new DateTime(2018, 11, 15, 20, 45, 3);
            //DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            //DateTime d4 = DateTime.Now;
            //DateTime d5 = DateTime.Today;
            //DateTime d6 = DateTime.UtcNow;

            //DateTime d7 = DateTime.Parse("2000-07-2");
            //DateTime d8 = DateTime.Parse("2000-07-2 15:30:00");

            //DateTime d9 = DateTime.ParseExact("2000-10-02", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //DateTime d10 = DateTime.ParseExact("2000-10-02 13:36:20", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            //Console.WriteLine("DateTime: " + d1);
            //Console.WriteLine("DateTime: " + d2);
            //Console.WriteLine("DateTime: " + d3);

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("Now: " + d4);
            //Console.WriteLine("Today: " + d5);
            //Console.WriteLine("UtcNow: " + d6);

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("DateTime.Parse: " + d7);
            //Console.WriteLine("DateTime.Parse: " + d8);

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("DateTime.ParseExact: " + d9);
            //Console.WriteLine("DateTime.ParseExact: " + d10);

            //----------------------TimeSpan----------------------

            //TimeSpan t1 = new TimeSpan(0, 1, 30);

            //TimeSpan t2 = new TimeSpan();
            //TimeSpan t3 = new TimeSpan(900000000L);
            //TimeSpan t4 = new TimeSpan(2, 11, 21);
            //TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            //TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);

            //TimeSpan t7 = TimeSpan.FromDays(1.5);
            //TimeSpan t8 = TimeSpan.FromHours(1.5);
            //TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            //TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            //TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            //TimeSpan t12 = TimeSpan.FromTicks(900000000L);

            //Console.WriteLine("TimeSpan(0, 1, 30): " + t1);
            //Console.WriteLine("Ticks: " + t1.Ticks);

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("TimeSpan(): " + t2);
            //Console.WriteLine("TimeSpan(900000000L): " + t3);
            //Console.WriteLine("TimeSpan(2, 11, 21): " + t4);
            //Console.WriteLine("TimeSpan(1, 2, 11, 21): " + t5);
            //Console.WriteLine("TimeSpan(1, 2, 11, 21, 321): " + t6);

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("FromDays(1.5): " + t7);
            //Console.WriteLine("FromHours(1.5): " + t8);
            //Console.WriteLine("FromMinutes(1.5): " + t9);
            //Console.WriteLine("FromSeconds(1.5): " + t10);
            //Console.WriteLine("FromMilliseconds(1.5): " + t11);
            //Console.WriteLine("FromTicks(900000000L): " + t12);

            //----------------------Operações com DateTime----------------------

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            //Console.WriteLine("DateTime: " + d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);

            //Console.WriteLine("--------------------------------------------");

            //string s1 = d.ToLongDateString();
            //string s2 = d.ToLongTimeString();
            //string s3 = d.ToShortDateString();
            //string s4 = d.ToShortTimeString();

            //string s5 = d.ToString();
            //string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            //string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            //Console.WriteLine("ToLongDateString(): " + s1);
            //Console.WriteLine("ToLongTimeString(): " + s2);
            //Console.WriteLine("ToShortDateString(): " + s3);
            //Console.WriteLine("ToShortTimeString(): " + s4);

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("ToString(): " + s5);
            //Console.WriteLine("ToString('yyyy - MM - dd HH: mm:ss'): " + s6);
            //Console.WriteLine("ToString('yyyy - MM - dd HH: mm:ss.fff'): " + s7);

            //Console.WriteLine("--------------------------------------------");

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            //DateTime d2 = d.AddHours(2);
            //DateTime d3 = d.AddMinutes(3);

            //Console.WriteLine("DateTime(2001, 8, 15, 13, 45, 58)" + d);

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("Add.Hours(2): " + d2);
            //Console.WriteLine("Add.Minutes(3): " + d3);

            //Console.WriteLine("--------------------------------------------");

            //DateTime d1 = new DateTime(2000, 10, 15);

            //DateTime d2 = new DateTime(2000, 10, 18);

            //TimeSpan t = d2.Subtract(d1);

            //Console.WriteLine("'DateTime(2000, 10, 15)': " + d1);

            //Console.WriteLine("'DateTime(2000, 10, 18)': " + d2);

            //Console.WriteLine("d2.Subtract(d1): " + t);

            //----------------------Operações com TimeSpan----------------------

            //TimeSpan t1 = TimeSpan.MaxValue;
            //TimeSpan t2 = TimeSpan.MinValue;
            //TimeSpan t3 = TimeSpan.Zero;

            //Console.WriteLine("TimeSpan.MaxValue: " + t1);
            //Console.WriteLine("TimeSpan.MinValue: " + t2);
            //Console.WriteLine("TimeSpan.Zero: " + t3);

            //Console.WriteLine("--------------------------------------------");

            //TimeSpan t1 = new TimeSpan(1, 30, 10);
            //TimeSpan t2 = new TimeSpan(0, 10, 5);

            //TimeSpan sum = t1.Add(t2);
            //TimeSpan dif = t1.Subtract(t2);
            //TimeSpan mult = t2.Multiply(2);
            //TimeSpan div = t2.Divide(2);

            //Console.WriteLine("t1: " + t1);
            //Console.WriteLine("t2: " + t2);

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("t1.Add(t2): " + sum);
            //Console.WriteLine("t1.Subtract(t2): " + dif);
            //Console.WriteLine("t2.Multiply(2): " + mult);
            //Console.WriteLine("t2.Divide(2): " + div);

            //----------------------DateTimeKind----------------------

            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            //Console.WriteLine("d1: " + d1);
            //Console.WriteLine("d1 Kind: " + d1.Kind);
            //Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            //Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("d2: " + d2);
            //Console.WriteLine("d2 Kind: " + d2.Kind);
            //Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            //Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("d3: " + d3);
            //Console.WriteLine("d3 Kind: " + d3.Kind);
            //Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            //Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());

            //----------------------ISO 8601----------------------

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
