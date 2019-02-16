using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string filename = "Kasimjan's file.txt"; // the name of file which I wanna create
            string PathString = @"C:\Users\User\Desktop\pp2"; //adress where i wanna create a new file 
            PathString = Path.Combine(PathString, filename); // ccombining their adresses
            FileStream fs = File.Create(PathString); // creating file
            fs.Close(); // we close to stop
            string PathString2 = @"C:\Users\User\Desktop"; // second adress where we wanna copy
            string destFile = System.IO.Path.Combine(PathString2, filename); // combining adress
            File.Copy(PathString,destFile, true);// we are copy to the new adress
            File.Delete(PathString); // and we delete original one 
        }
            

    }
}
