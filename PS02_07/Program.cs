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
            Console.Write("Enter Array Length: ");
            int arrayLength = Console.ReadLine();
            int[] numbers = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter element {i}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Your array is {numbers}");
            Console.WriteLine($"Sum of Numbers is = {sumOfNumbers(numbers)}");
        }

        static int sumOfNumbers(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }q
    }
}
