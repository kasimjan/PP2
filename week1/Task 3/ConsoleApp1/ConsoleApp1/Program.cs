using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // we create new int by reading console  
            string s=Console.ReadLine(); // we create string s  
            string[] a = s.Split(' '); // we create array and every element of this array equals to every char of string s if only if char != ' ' (ПРОБЕЛ)
            Console.WriteLine(); // at console we write one empty LINE
            string[] b = new string[n * 2]; // new array with size n*2
            for( int i=0; i<n; i++) // new cycle with dim=n
            {
                b[i * 2] = a[i];  // it is method to write one element of a(a[i]) two times in (b[i],b[i+1])
                b[i * 2 + 1] = a[i];
            }
            for( int i=0; i<n*2; i++)
            {
                Console.Write(b[i]); // finally we out every element of array b
                Console.Write(' ');// пробел после каждого элемента 
            }
        }
    }
}