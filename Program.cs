using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

      
            //var date = "31-12-2019";
            var date = "11-12-2019";
            DateTime parsedDate;
            if (DateTime.TryParseExact(date, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                string formattedDate = parsedDate.ToString("dd MMMM yyyy");
                Console.WriteLine(formattedDate);
                //Debug.WriteLine(formattedDate);
                string formattedDate1 = parsedDate.Day + GetOrdinalSuffix(parsedDate.Day) + " " + parsedDate.ToString("MMMM yyyy");
                Console.WriteLine(formattedDate1);
                Debug.WriteLine(formattedDate1);
            }
            else
            {
                Console.WriteLine("Invalid date format");
                Debug.WriteLine("Invalid date format");
            }





        }
        public static string GetOrdinalSuffix(int day)
        {
            switch (day)
            {
                case 1:
                case 21:
                case 31:
                    return "st";
                case 2:
                case 22:
                    return "nd";
                case 3:
                case 23:
                    return "rd";
                default:
                    return "th";
            }
        }
    }
}
