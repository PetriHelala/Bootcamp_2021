using System;

namespace trainingday_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a date: ");
            string value = Console.ReadLine();
            DateTime date1 = DateTime.Parse(value);

            Console.WriteLine("Give me a second date: ");
            value = Console.ReadLine();
            DateTime date2 = DateTime.Parse(value);
            
            TimeSpan difference = date2 - date1;
            Console.WriteLine("Difference in days: " + difference.Days);
            Console.WriteLine("Difference in hours: " + difference.Hours);
            Console.WriteLine("Difference in total days: " + difference.TotalHours);
            Console.WriteLine("Difference in total hours: " + difference.TotalHours);
            
        }
    }
}
