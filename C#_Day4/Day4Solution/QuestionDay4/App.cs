using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuestionDay4
{
    class App
    {
        AppEngine appEngine;
        App()
        {
            appEngine = new AppEngine();
        }
        void UserInput()
        {
            int choice = 0;
            do
            {
                PrintMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Student student = new Student();
                        student.TakeStudentData();
                        appEngine.Register(student);
                        break;
                    case 2:
                        Course course = new Course();
                        course.TakeCourseData();
                        appEngine.Introduce(course);
                        break;
                    case 3:
                        TakeEnrolment();
                        break;
                    case 4:
                        PrintStudents();
                        break;
                    case 5:
                        PrintCourses();
                        break;
                    case 6:
                        PrintEnrollments();
                        break;
                    case 7:
                        Console.WriteLine("Bye bye...");
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Please try again..");
                        break;
                }
            } while (choice!=7);
        }
        void PrintMenu()
        {
            Console.WriteLine("Select From options");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Course");
            Console.WriteLine("3. Enrol Student");
            Console.WriteLine("4. List all studnets");
            Console.WriteLine("5. List all courses");
            Console.WriteLine("6. List all enrollments");
            Console.WriteLine("7. Exit");
        }

        Student FindStudentByID(int id)
        {
            Student student = null;
            Student[] students = appEngine.ListOfStudents();
            for (int i = 0; i < students.Length; i++)
            {
                if(students[i]!= null && students[i].Id == id)
                {
                    student = students[i];
                    break;
                }
            }
            return student;
        }
        Course FindCourseByID(int id)
        {
            Course course = null;
            Course[] courses = appEngine.ListOfCourses();
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] != null && courses[i].Id == id)
                {
                    course = courses[i];
                    break;
                }
            }
            return course;

        }
        void TakeEnrolment()
        {
            PrintCourses();
            PrintStudents();
            Console.WriteLine("Please enter the student id you wish to enroll");
            int sid = Convert.ToInt32(Console.ReadLine());
            Student eStudent = FindStudentByID(sid);
            if (eStudent == null)
            {
                Console.WriteLine("No such student");
                return;
            }
            Console.WriteLine("Please enter the course id you wish the student to enroll for" );
            int cid = Convert.ToInt32(Console.ReadLine());
            Course eCourse = FindCourseByID(cid);
            if (eCourse == null)
            {
                Console.WriteLine("No such Course");
                return;
            }
            appEngine.enroll(eStudent, eCourse);
        }
        void PrintStudents()
        {
            Console.WriteLine("Students");
            Console.WriteLine("--------------------------------");
            Student[] students = appEngine.ListOfStudents();
            foreach (var item in students)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("--------------------------------");
                }
            }
        }
        void PrintCourses()
        {
            Console.WriteLine("Courses");
            Console.WriteLine("--------------------------------");
            foreach (var item in appEngine.ListOfCourses())
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("--------------------------------");
                }
            }
        }
        void PrintEnrollments()
        {
            Console.WriteLine("Enrolments");
            Console.WriteLine("--------------------------------");
            foreach (var item in appEngine.ListOfEnrollments())
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("--------------------------------");
                }
            }
        }
        static void Main(string[] a)
        {
            App app = new App();
            app.UserInput();
            Console.ReadKey();
        }
    }
}
