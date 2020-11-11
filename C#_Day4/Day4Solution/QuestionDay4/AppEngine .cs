using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionDay4
{
    class AppEngine
    {
        Course[] courses = new Course[5];
        Student[] students = new Student[10];
        Enroll[] enrolments = new Enroll[100];
        int CourseCounter, StudentCounter, EnrolCounter;
        public AppEngine()
        {
            CourseCounter = -1;
            StudentCounter = -1;
            EnrolCounter = -1;
        }
        public void Introduce(Course course)
        {
            if (CourseCounter < 5)
            {
                CourseCounter++;
                courses[CourseCounter] = course;
                Console.WriteLine("Course added");
            }
            else
                Console.WriteLine("We already have enough courses");
        }
        public void Register(Student student)
        {
            if (StudentCounter < 5)
            {
                StudentCounter++;
                students[StudentCounter] = student;
                Console.WriteLine("Student added");
            }
            else
                Console.WriteLine("The addmission for this year is complete");
        }
        public Student[] ListOfStudents()
        {
            return students;
        }
        public Course[] ListOfCourses()
        {
            return courses;
        }
        public void enroll(Student student, Course course)
        {
            if (EnrolCounter < 100)
            {
                EnrolCounter++;
                Enroll enroll = new Enroll(student, course, DateTime.Today);
                enrolments[EnrolCounter] = enroll;
                Console.WriteLine("Student enrolled");
            }
            else
                Console.WriteLine("All enrolments done already");
        }
        public Enroll[] ListOfEnrollments()
        {
            return enrolments;
        }
    }
}
