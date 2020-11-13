using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project
{
    class UnderstandDelegate
    {
        //public delegate void CreateType(int n1);
       // CreateType reff;
        List<Student> students = new List<Student>();
        UnderstandDelegate()
        {
            students.Add(new Student(101, "Ramu"));
            students.Add(new Student(102, "Bimu"));
            students.Add(new Student(103, "Somu"));
            students.Add(new Student(104, "Gimu"));
        }
        void FindStudnetByID()
        {
            Console.WriteLine("Please enter the id");
            int id = Convert.ToInt32(Console.ReadLine());
            Predicate<Student> predicate = s => s.Id == id;
            Student student = students.Find(predicate);
            Console.WriteLine(student);
        }
        void MoreOnDelegates()
        {
            //Action,Func,Predicate
            //Action - > upto 16 parameters but no return
            //reff = (num1) => Console.WriteLine("The number that is given is " + num1);
            Action<int> actionRef = (num1) => Console.WriteLine("The number that is given is "+num1);
            actionRef += (num1) => Console.WriteLine("The number add 10 that is given is " + (num1+10));
            actionRef(10);
            //Func - upto 16 parameters and one return type
            Func<double,double,double> funcRef = (n1, n2) => (double)(n1 / n2);
            double dRes = funcRef(20, 3);
            Console.WriteLine("The result is "+dRes);
            //predicate - 1 parameter and bool as return type
            Predicate<int> predicateRef = (n1) => n1 > 10;
            Console.WriteLine("Is the number > 10 ??"+predicateRef(20));
            //reff(20);
        }
        static void Main()
        {
            new UnderstandDelegate().FindStudnetByID();
            Console.ReadKey();
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return "Id : "+Id+" Name : "+Name;
        }
        public Student()
        {
        }
    }
}
