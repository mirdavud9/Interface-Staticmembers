using Interface__Static_members;
using System;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Kamil", "Zeynalli");
        Student student2 = new Student("Filankes", "Chagayev");
 


        Group group1 = new Group("GYM Club");

        group1.AddStudent(student1);
        group1.AddStudent(student2);
        group1.ShowStudents();
    }
}
