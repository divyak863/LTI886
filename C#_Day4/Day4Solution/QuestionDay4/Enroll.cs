using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionDay4
{
    class Enroll
    {

        public Student student { get; set; }
        public Course course { get; set; }
        public DateTime EnrollmentDate { get; set; }
        

        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            EnrollmentDate = enrollmentDate;
        }
        public override string ToString()
        {
            return student+"\n------------------"
                +course+"\n------------------"
                + EnrollmentDate.ToShortDateString();
        }
        public Enroll()
        {
        }
    }
}
