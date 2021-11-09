using System;
using System.Globalization;

namespace DateTimeDifferenceApp
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date1 = ReadDateFromUser("Enter the first date: ");
            DateTime date2 = ReadDateFromUser("Enter the second date: ");

            CultureInfo enUS = new("en-US");
            CultureInfo fr = new("fr");
            Console.WriteLine();
            Console.WriteLine("First day (default format): " + date1);
            Console.WriteLine("Second day (default format): " + date2);
            Console.WriteLine("Second day (en-US): " + date1.ToString(enUS));
            Console.WriteLine("Second day (fr): " + date2.ToString(fr));
            Console.WriteLine("Second day (custom): " + date1.ToString("yyyy $ MM"));
            Console.WriteLine();

            // culture info format example
            // DateTime parsedDate = DateTime.Parse("11/6/2021, enUS");

            TimeSpan difference = date2 - date1;
            Console.WriteLine("Difference in days: " + difference.TotalDays);
            Console.WriteLine("Difference in hours: " + difference.TotalHours);

        }

        private static DateTime ReadDateFromUser(string prompt)
        {

            while (true)
            {
                Console.WriteLine(prompt);
                string value = Console.ReadLine();
                try
                {
                    DateTime date = DateTime.Parse(value);
                    return date;
                }
                catch
                {
                    Console.WriteLine("The date entered was invalid. Please try again: ");
                }

            }

        }
    }
}
