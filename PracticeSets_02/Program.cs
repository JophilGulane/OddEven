using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print even numbers from 1 - 20
                for (int i = 0; i <= 20; i++){
                if(i % 2 == 0){
                    System.Console.Write(i);
                }
            }
        }
    }
}
