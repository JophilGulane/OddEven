using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes a character as input and outputs whether it is a vowel or a consonant. 
            Console.Write("Enter a letter: ");
            char letter = Convert.ToChar(Console.ReadLine().ToUpper());

            if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                Console.WriteLine($"The letter {letter} is a vowel.");
            }
            else
            {
                Console.WriteLine($"The letter {letter} is a consonant.");

            }

        }
    }
}
