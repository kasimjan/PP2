using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    //Task2
    {                                                                        //создаем класс
        static void Main(string[] args)
        {
            Student s1 = new Student("Kasimjan", "18BD1111**", 1);         // и внутри класса создаем стринг s1
               s1.September();
        }
    }
    class Student                                                 //для string s1 создаем отдельный класс
    {
        string Name { get; set; }                                 //внуртри класса выводим данные студента ,
        string ID { get; set; }
        int YoS { get; set; }
        public Student(string Name, string ID, int YoS)         // конструктор создаем
        {
            this.Name = Name;
            this.ID = ID;
            this.YoS = YoS;

        }
        public void September()           //  создаю функцияю september
        {
            YoS++;     //год увеличили на 1
            Console.WriteLine("Student: {0}, ID:{1}, Year of study: {2}", Name, ID, YoS);
            Console.ReadKey();
        }
    }
}