using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr= new StreamReader("input.txt"); // we create StreamReader with name sr wich will read all what will in ("input.txt")
            string s= sr.ReadToEnd(); // We create string s which equal to all chars in sr 
            sr.Close();
            int cnt = 0;    // we create int wich enitailly equal to 0
            string s2 = s; // new string which eqal to s
            for(int i=0; i<s.Length; i++) // new cycle with dim=s.Length
            {
                    if (s[i] == s[s.Length-1-i]) // this condiational for checking is string polindrom or not
                    {
                        cnt=cnt+1;   
                    }
            }
            StreamWriter sw = new StreamWriter("output.txt");
            if (cnt == s.Length) // if string s is polindrome we Write "YES"
            {   sw.WriteLine("YES");
                sw.Close();
            }
            else // else we write "NO"
            sw.WriteLine("NO");
            sw.Close();
        }
    }
}
