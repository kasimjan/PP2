using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static bool isPrime(int x) // this function for checking is number prime or not
        {
            if(x==2 || x == 3) // if number equal to 2 or equal to 3 we return true
            {
                return true;
            }
            for (int i = 2; i * i <= x; i++) // new cycle with dim = root x
            {
                if (x % i == 0 || x < 2) // if number is divisible by any number which is smaller than root of this number we return false
                {
                    return false;
                }
            }
            return true; // if program didn't return anything before here we return true
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            string[] a = sr.ReadToEnd().Split(' ');
            for( int i=0; i<a.Length; i++)
            {
                int x = int.Parse(a[i]);
                if(isPrime(x)==true && x > 1)
                {
                    sw.Write(x);
                    sw.Write(' ');
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}
