using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day7Project
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Fees { get; set; }
        public void TakeCourseDataFromUser()
        {
            Console.WriteLine("Please enter the course name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the fee amount");
            Fees = float.Parse(Console.ReadLine());
        }
    }
}
