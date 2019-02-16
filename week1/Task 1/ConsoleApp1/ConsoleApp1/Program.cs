 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        public static bool isPrime(int x) // this function for checking numbers is prime or not
        {
            if(x==2 || x == 3) // if number=2 or =3 we return true
            {
                return true;
            }
            // this bool function for checking is number prime or not.
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0 || x<2) // if (number will divisible for any number which is smaller or equal to root x) we return false
                                       // or if number smaller than 2 we return false
                    return false;
            }
            return true; // if program didn't return anything before here we return true
        }

        static void Main(string[] args)
        {
            int n; //we create number with name n
            int cnt = 0; // we create number with name cnt and we give enatial 0
            n = int.Parse(Console.ReadLine()); // we write n at console
            string s = ""; //we create empty string
            string[] arr = Console.ReadLine().Split(' '); // we create string array 
            for (int i = 0; i < n; i++) // we create cycle with dim=n
            {
                int x; // we create integer x
                x = int.Parse(arr[i]); // we add int x n times 
                if (isPrime(x) == true && x>=2) //here we check is number a prime or not, 
                                               // if so we count and add this numbers to string s;
                {
                    cnt++;
                        s = s + x+" ";
                }
            }
            Console.WriteLine(cnt); //writing at console how many numbers are prime
            Console.WriteLine(s); // and finally we write at console prime numbers !
        }
    }
}