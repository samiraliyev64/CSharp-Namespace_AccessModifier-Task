using System;

namespace Namespace_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Samir", "Aliyev", 20, 457);
            Student student1 = new Student("Ferrux", "Aliyev", 19, 564);
            Student student2 = new Student("Kamal", "Cebrayilov", 22, 335);
            Student student3 = new Student("Aysel", "Elekberova", 23, 555);

            Group group = new Group();
            group.AddStudent(student);
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.Sort();
            group.GetAllStudents();

            
        }
    }
}
