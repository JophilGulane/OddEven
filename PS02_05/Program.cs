using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes a string as input and outputs the frequency of each character in the string. 
            Console.Write("Enter your string: ");
            string word = Console.ReadLine();
            int[] freq = new int[256];

            foreach (char letter in word)
            {
                freq[letter]++;
            }
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    Console.WriteLine($"'{(char)i}' : {freq[i]}");
                }
            }

        }
    }
}
