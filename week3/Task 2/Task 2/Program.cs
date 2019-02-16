using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_2
{
    class Program
    {
        class FarManager
        {
            int cursor;
            int cnt;
            public FarManager()
            {
                cursor = 0;
            }
            public void Show(DirectoryInfo dire, int z)
            {
                FileSystemInfo[] d = dire.GetFileSystemInfos();
                for (int i = 0; i < d.Length; i++)
                {
                    if (z == i)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine(i + 1 + ". " + d[i].Name);
                    }
                    else if (d[i].GetType() == typeof(FileInfo))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(i + 1 + ". " + d[i].Name);
                    }
                    else if (d[i].GetType() == typeof(DirectoryInfo))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(i + 1 + ". " + d[i].Name);
                    }
                }
            }
            public void Up()
            {
                cursor--;
                if (cursor < 0)
                {
                    cursor = cnt - 1;
                }
            }
            public void Down()
            {
                cursor++;
                if (cursor == cnt)
                {
                    cursor = 0;
                }
            } // TASK 1
            public void Start(string path)
            {
                ConsoleKeyInfo button = Console.ReadKey();
                while (button.Key != ConsoleKey.Escape)
                {
                    DirectoryInfo dir = new DirectoryInfo(path);
                    FileSystemInfo[] d = dir.GetFileSystemInfos();
                    cnt = d.Length;
                    Show(dir, cursor);
                    button = Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    if (button.Key == ConsoleKey.F2) //F2 need to rename
                    {
                        if (d[cursor].GetType() == typeof(FileInfo))// rename the name of file 
                        {
                            string s = Console.ReadLine();//write name 
                            string s1 = Path.Combine(dir.FullName, s); // combining this name with name 
                            File.Move(d[cursor].FullName, s1); // rename
                            Console.BackgroundColor = ConsoleColor.Black; //need to see changes 
                            Console.Clear();
                        }
                        if (d[cursor].GetType() == typeof(DirectoryInfo))//for folders
                        {
                            string s = Console.ReadLine();
                            string s1 = Path.Combine(dir.FullName, s);
                            Directory.Move(d[cursor].FullName, s1);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                        }
                    }
                    if (button.Key == ConsoleKey.Delete) // del for delete
                    {
                        if (d[cursor].GetType() == typeof(FileInfo))//deleting file
                        {
                            File.Delete(d[cursor].FullName);
                        }
                        if (d[cursor].GetType() == typeof(DirectoryInfo)) // for folder
                        {
                            DirectoryInfo ddd = new DirectoryInfo(d[cursor].FullName);
                            FileSystemInfo[] dd = ddd.GetFileSystemInfos(); //  check this folder is it has files or folders
                            if (dd.Length == 0) // if no so delete
                            {
                                Directory.Delete(d[cursor].FullName);
                            }
                            else
                            {
                                Console.WriteLine("This folder not empty, so it can't be deleted"); //  else we say it canit be deleted
                            }

                        }
                    }
                    if (button.Key == ConsoleKey.UpArrow)
                    {
                        Up();
                    }
                    if (button.Key == ConsoleKey.DownArrow)
                    {
                        Down();
                    }
                    if (button.Key == ConsoleKey.Enter)
                    {
                        if (d[cursor].GetType() == typeof(FileInfo)) //for open textfiles
                        {
                            StreamReader sr = File.OpenText(d[cursor].FullName);
                            string s = sr.ReadToEnd(); //  we  save all what this file has to the string 
                            sr.Close();//закрываем
                            Console.WriteLine(s);// and show that to the console 
                        }
                        if (d[cursor].GetType() == typeof(DirectoryInfo))
                        {
                            path = d[cursor].FullName;
                            cursor = 0;
                        }
                    }
                    if (button.Key == ConsoleKey.Backspace)
                    {
                        cursor = 0;
                        dir = dir.Parent;
                        path = dir.FullName;
                    }
                }
            }
        }
    
            static void Main(string[] args)
            {
                FarManager far = new FarManager();
                far.Start(@"C:\Users\User\Desktop\pp2");
            }
        }
    }