using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
    
namespace addition  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            int Number1, Number2;  
            Console.WriteLine("please enter a number");  
            Number1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("please enter a number");  
            Number2 = Convert.ToInt32(Console.ReadLine());  
            int Sum;  
            Sum = Number1 + Number2;  
            Console.WriteLine("Sum of two Numbers:" + Sum.ToString());  
            Console.ReadLine();  
        }  
    }  
}  