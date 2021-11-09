using System;
using System.IO;

namespace trainingday_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int currentLine = 1;
            string filename = @"C:\users\zenid\desktop\bootcamp_koulutus\training\trainingday_8\ConsoleApp\numbers.txt";
            string[] lines = File.ReadAllLines(filename);
          
            foreach(string line in lines) 
            {
                try 
                {
                    int value = int.Parse(line);
                    sum += value; // sum = sum + value;
                }
                catch 
                {
                    Console.WriteLine("Exception caught: Line " + currentLine + " with value \"" + line + "\" is not a valid value.");
                }
                currentLine++;
            }
            
            Console.WriteLine("Calculated sum is " + sum);
        }
    }
}
