using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes a string as input and outputs whether it is a palindrome. 
            Console.Write("Enter a word to check if its a palindrome: ");
            string userInput = Console.ReadLine();

            if (isPalindrome(userInput))
            {
                Console.WriteLine("The word is a palindrome.");
            }
            else
            {
                Console.WriteLine("The word is not a palindrome.");
            }
        }

        static bool isPalindrome(string userInput)
        {
            userInput = userInput.Replace(" ", "").ToLower();

            for (int i = 0; i < userInput.Length / 2; i++)
            {
                if (userInput[i] != userInput[userInput.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
