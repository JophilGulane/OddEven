using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++){
                if(i % 2 != 0){
                    System.Console.Write(i + " ");
                }
            }
        }
    }
}
