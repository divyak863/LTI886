using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionDay4
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Course(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Course()
        {
        }
        public void TakeCourseData()
        {
            Console.WriteLine("Please enter the Course ID");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Course Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the Course Price");
            Price= Convert.ToDouble(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Course Detatails\nCourse ID : " + Id
                + "\nCourse Name : " + Name
                + "\nCourse Price : " + Price;
        }
    }
}
