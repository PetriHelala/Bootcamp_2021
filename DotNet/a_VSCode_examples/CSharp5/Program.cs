using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            int number = 1000;

            if (number < 100) {
                System.Console.WriteLine("The number is less than 100!");
            }
            else if (number >= 100) {
                System.Console.WriteLine("The number is exactly or over 100!");
            }
            else System.Console.WriteLine("Give a number!");
            */

            /*
            Additional testing with CSharp

            This parses a number given to the console, does not take letters only numbers.
            It then adds 10 to the number given. The WriteLine method gives the final value.

            Console.WriteLine("Please enter a number:");
            string number = Console.ReadLine();
            int value = int.Parse(number);
            value = value + 10;
            Console.WriteLine(value);
            */

            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            This is two ways to go through an array of numbers and displaying them in console. 
            The foreach is a more modern way to do it and much faster.

            int[] number = { 2, 4, 6, 8, 9 };
            for (int i = 0; i < number.Length; i++) {

                int valueInArray = number[i];
                Console.WriteLine(valueInArray);
            }

            foreach (int value in number)
            {
                Console.WriteLine(value);
            }
            */

            /*
            The 'double' is a floating point number type designator.
            The curly brackets inside the WriteLine are the style the parameters are shown (0 gives just the number given, 1:N2 truncates the number given to two decimals)
            double result = 123 / 4.7; 
            Console.WriteLine(result);
            Console.WriteLine("{0} - {1:N2}", 987, result);
            */

            
        }
    }
}
