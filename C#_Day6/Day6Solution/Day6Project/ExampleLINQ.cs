using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Project
{
    class ExampleLINQ
    {
        void UnderstandingLINQ()
        {
            int[] scores = { 100, 80, 69, 56, 81, 74, 50 };
            //int[] TopScore = new int[scores.Length];
            //int count = 0;
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if(scores[i]>75)
            //    {
            //        TopScore[count] = scores[i];
            //        count++;
            //    }
            //}
            //var TopScores = from s in scores where s > 75 select s;//LINQ
            var TopScores = scores.Where(s => s > 75);
            foreach (var item in TopScores)
            {
                Console.WriteLine(item);
            }
        }
        void UnderstandingMoreonLINQ()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(101, "Ramu"));
            students.Add(new Student(102, "Bimu"));
            students.Add(new Student(103, "Somu"));
            students.Add(new Student(104, "Gimu"));

            Student student = students.Where(s => s.Id == 101).FirstOrDefault();
            Console.WriteLine(student);
            Console.WriteLine("--------------------------");
            var myStudents1 = students.Where(s => s.Name.Contains("i")).OrderBy(s => s.Name);
            foreach (Student student1 in myStudents1)
            {
                Console.WriteLine(student1);
            }
            Console.WriteLine("--------------------------");
            List<Student> myStudents2 = students.Where(s => s.Name.Contains("i")).OrderByDescending(s => s.Name).ToList();
            foreach (Student student1 in myStudents2)
            {
                Console.WriteLine(student1);
            }
            Console.WriteLine("--------------------------");
            students.Add(new Student(105, "Gimu"));
            students.Add(new Student(100, "Bimu"));
            List<Student> myStudents3 = students.Where(s => s.Name.Contains("i")).OrderBy(s => s.Name).ThenBy(s=>s.Id).ToList();
            foreach (Student student1 in myStudents3)
            {
                Console.WriteLine(student1);
            }
            Console.WriteLine("--------------------------");
            var myStudents4 = students.Where(s => s.Name.Contains("i")).OrderBy(s => s.Name)
                .Select(s => new { ID=s.Id,
                                    Age=s.Id-100,
                                    Name = s.Name.Substring(0,2)});
            foreach (var item in myStudents4)
            {
                Console.WriteLine(item.ID+" "+item.Age + " " + item.Name);
            }
            Console.WriteLine("--------------------------");
            var myStudents5 = students.GroupBy(s => s.Name);
            foreach (var item in myStudents5)
            {
                Console.WriteLine("The ids with the name "+item.Key);
                foreach (var id in item)
                {
                    Console.WriteLine(id);
                }
                Console.WriteLine("*********************");
            }

        }

        static void Main()
        {
            new ExampleLINQ().UnderstandingMoreonLINQ();
            Console.ReadKey();
        }
    }
}
