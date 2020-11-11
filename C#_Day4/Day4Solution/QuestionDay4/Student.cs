using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionDay4
{
    class Student
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public Student(int id, int age, string name)
        {
            Id = id;
            Age = age;
            Name = name;
        }
        public void TakeStudentData()
        {
            Console.WriteLine("Please enter the student ID");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the student Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the student Age");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public Student()
        {
        }
        public override string ToString()
        {
            return "Student Detatails\nStudent ID : " + Id
                + "\nStudent Name : " + Name
                + "\nStudent Age : " + Age;
        }
    }
}
