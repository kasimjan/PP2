using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; // we create new int with name n
            n = int.Parse(Console.ReadLine()); //and add this n
            for (int i = 0; i <= n; i++)
            { //we create new cycle with dim=n+1 (0,1,......n)
                for (int j = 0; j < i; j++)
                {
                    // we create new cycle in the cycle with dim=i (0,1,2......i-1)
                    if (j <= i)
                    { // if this condion is correct we write "[*] " with( пробел)
                        Console.Write("[*] ");
                    }
                }
                Console.WriteLine(); // it is endl in C++
            }
        }
    }
}
