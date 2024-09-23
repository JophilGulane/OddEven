using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes an array of numbers as input and outputs the sum of the numbers. 
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
        
            int sum = 0;
        
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
        
            Console.WriteLine("Sum of the digits: " + sum);
        }
    }
}
