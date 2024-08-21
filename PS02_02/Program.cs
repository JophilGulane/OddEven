using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_02Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints all the Odd numbers
            for (int i = 0; i <= 20; i++){
                if(i % 2 != 0){
                    System.Console.Write(i + " ");
                }
            }
        }
    }
}
