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
            int arrayLength = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter element at index {i}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Your array is: ");

            foreach (int ele in numbers)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum of Numbers in Array is = {sumOfArrayNum(numbers)}");
        }

        static int sumOfArrayNum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
