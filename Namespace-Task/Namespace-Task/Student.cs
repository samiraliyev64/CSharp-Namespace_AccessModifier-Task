using System;
using System.Collections.Generic;
using System.Text;

namespace Namespace_Task
{
    class Student
    {
        public string Name;
        public string Surname;
        public int Point;
        public int Age;

        public static int Serial = 1;
        public int ID;
        
        


        public Student(string Name, string Surname, int Age, int Point)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.Point = Point;
            this.ID = Serial++;    
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}\nSurname : {Surname}\nAge : {Age}\nPoint : {Point}\nID : {ID}");
        }

 
    }
}
