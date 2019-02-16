using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3
{
    class FarManager // новый класс
    {
        int cursor; //  cursor to see where i am 
        int cnt; // added to count how many files or folders in directory
        public FarManager() // new empty constructer
        {
            cursor = 0; // fisrtly cursor on the top 
        }
        public void Show(DirectoryInfo dire, int z) // in this function we give dif for cursor
        {
            FileSystemInfo[] d = dire.GetFileSystemInfos(); // i created array for taking all files in the folder of this directory 
            for (int i = 0; i < d.Length; i++) // new cycle with dim=d
            {
                if (z == i) // where cursur colod should be different 
                {
                    Console.ForegroundColor = ConsoleColor.White; // white and red)
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(i + 1 + ". " + d[i].Name); // then we take out name of file or folder 
                }
                else if (d[i].GetType() == typeof(FileInfo)) //  if it is file 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; //yellow and black 
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(i + 1 + ". " + d[i].Name); // take out index of this file 
                }
                else if (d[i].GetType() == typeof(DirectoryInfo)) // if it is folder
                {
                    Console.ForegroundColor = ConsoleColor.White; //white and black
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(i + 1 + ". " + d[i].Name);// index and name of folder
                }
            }
        }
        public void Up() // if user will push UP we should --
        {
            cursor--;
            if (cursor < 0) // if we are on the top he will transfer us to the down 
            {
                cursor = cnt - 1;
            }
        }
        public void Down() //if user will push Down ++
        {
            cursor++;
            if (cursor == cnt) // if we are on final file or directory we transfer to the top
            {
                cursor = 0;
            }
        }
        public void Start(string path) // function start 
        {
            ConsoleKeyInfo button = Console.ReadKey(); // everytime when we push program will write ro the button
            while (button.Key != ConsoleKey.Escape) // if user will push Escape it should stop to work 
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileSystemInfo[] d = dir.GetFileSystemInfos(); // папке we create array where we will keep all info from the file
                cnt = d.Length; // we count how many folder or files
                Show(dir, cursor); //we call function Show wirh cursor to give color
                button = Console.ReadKey(); //for pushing every time 
                Console.BackgroundColor = ConsoleColor.Black; //background color will be black
                Console.Clear(); //  for see new (кадр) by clearing old 
                if (button.Key == ConsoleKey.UpArrow) // if we push uparrow we call function
                {
                    Up();
                }
                if (button.Key == ConsoleKey.DownArrow) //if we push downarrow we call function
                {
                    Down();
                }
                if (button.Key == ConsoleKey.Enter) //if we push entee we should open this folder
                {
                    path = d[cursor].FullName; 
                    cursor = 0; // it is for starting on the top
                }
                if (button.Key == ConsoleKey.Backspace) //if it is Backspace we should out from this folder
                {
                    cursor = 0;
                    dir = dir.Parent;
                    path = dir.FullName;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FarManager far = new FarManager(); // new class
            far.Start(@"C:\Users\User\Desktop\pp2"); //  I give adress where it shoulde be started and call function 
        }
    }
}