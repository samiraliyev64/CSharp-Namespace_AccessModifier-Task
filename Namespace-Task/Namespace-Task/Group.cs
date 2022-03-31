using System;
using System.Collections.Generic;
using System.Text;

namespace Namespace_Task
{
    class Group
    {
        public int currentPosition = 0;

        private static int _No=200;

        public int No
        {
            get
            {
                return _No;   
            }

            set { }
        }

        public Group()
        {
            _No++;         
        }

        public Student[] student = new Student[] { };


        public void AddStudent(Student obyekt)
        {
            Array.Resize(ref student,student.Length+1);
            student[currentPosition] = obyekt;
            currentPosition++;

        }

        public void GetAllStudents()
        {
            for (int i = 0; i < student.Length; i++)
               
            {
                Console.WriteLine($"Ad : {student[i].Name}\nSoyad : {student[i].Surname}\nYaş : {student[i].Age}\nID : {student[i].ID}\nBal : {student[i].Point}\n");
            }
        }

        public void Sort()
        {
            Student temp;
            for (int i = 0; i < student.Length; i++)
            {
                for (int j = 0; j < student.Length; j++)
                {
                    if(student[j].Point > student[i].Point)
                    {
                        temp = student[j];
                        student[j] = student[i];
                        student[i] = temp;

                    }
                }
            }
        }

    }
}
