using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static void Printer( int x)
        {
            for (int i = 0; i < x; i++)
                Console.Write("  ");
        }
        public static void Task3(DirectoryInfo dir, int x)
        {
            foreach (FileInfo f in dir.GetFiles())
            {
                Printer(x);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                Printer(x);
                Console.WriteLine(d.Name);
                Task3(d, x + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo proga = new DirectoryInfo(@"C:\Users\User\Desktop\math");
            Task3(proga, 1);
        }
    }
}
