using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Day7Project
{
    class Program
    {
        SqlConnection conn;
        SqlCommand cmdGetStudents,cmdInsertStudnet,cmdUpdateStudentName,cmdDeleteStudent;
        List<Student> students;
        Program()
        {
            
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCon"].ConnectionString);
            //conn.Open();
            //Console.WriteLine("Connection success");
        }
        void GetStudentsDataFromDatabase()
        {
            //cmdGetStudents = new SqlCommand("select * from tblStudent",conn);
            students = new List<Student>();
            try
            {
                cmdGetStudents = new SqlCommand();
                cmdGetStudents.CommandText = "select * from tblStudent";
                cmdGetStudents.Connection = conn;
                conn.Open();
                SqlDataReader drStudents = cmdGetStudents.ExecuteReader();
                Student student;
                while (drStudents.Read())
                {
                    student = new Student();
                    student.Id = Convert.ToInt32(drStudents[0]);
                    student.Name = drStudents[1].ToString() ;
                    //int age;
                    //Int32.TryParse(drStudents[2].ToString(), out age);
                    //student.Age = age;
                    try
                    {
                        student.Age = Convert.ToInt32(drStudents[2]);
                    }
                    catch (InvalidCastException ice)
                    {
                    }
                    students.Add(student);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
                Console.WriteLine("-------------------");
                Console.WriteLine(se.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }
        void PrintStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine("--------------------------------");
            }
        }
        void InsertStudentToDatabase()
        {
            Student student = new Student();
            student.TakeStudentDataFromUser();
            // insert into tblStudent(name, age) values('Komu', null)
            try
            {
                cmdInsertStudnet = new SqlCommand();
                cmdInsertStudnet.CommandText = "insert into tblStudent(name, age) values(@studentname,@studentage)";
                cmdInsertStudnet.Connection = conn;
                cmdInsertStudnet.Parameters.Add("@studentname", SqlDbType.VarChar, 20);
                cmdInsertStudnet.Parameters[0].Value = student.Name;
                cmdInsertStudnet.Parameters.AddWithValue("@studentage", student.Age);
                conn.Open();
                int iResult = cmdInsertStudnet.ExecuteNonQuery();
                if (iResult > 0)
                {
                    Console.WriteLine("Student record inserted.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("-------------------");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }
        void UpdateStudentNameUsingSP()
        {
            Console.WriteLine("Update Studen Details");
            Console.WriteLine("****************************");
            Console.WriteLine("Please enter the student ID");
            int id;
            Int32.TryParse(Console.ReadLine(), out id);
            Student student = null;
            try
            {
              student  = students.Where(s => s.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine("No such student");
            }
            if (student != null)
            {
                Console.WriteLine("The studnets detais: ");
                Console.WriteLine(student);
                Console.WriteLine("Please enter the Student name for updation");
                string name = Console.ReadLine();
                cmdUpdateStudentName = new SqlCommand("proc_UpdateStudnetName",conn);
                cmdUpdateStudentName.CommandType = CommandType.StoredProcedure;
                cmdUpdateStudentName.Parameters.AddWithValue("@sid", id);
                cmdUpdateStudentName.Parameters.AddWithValue("@sname", name);
                try
                {
                    conn.Open();
                    int iResult = cmdUpdateStudentName.ExecuteNonQuery();
                    if(iResult>0)
                        Console.WriteLine("Student name updated");
                    else
                        Console.WriteLine("Student name not updated");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("-------------------");
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                Console.WriteLine("No such student");
            }
           
        }

        void DeleteStudentRecordFromDatabase()
        {
            Console.WriteLine("Delete Student");
            Console.WriteLine("****************************");
            Console.WriteLine("Please enter the student ID");
            int id;
            Int32.TryParse(Console.ReadLine(), out id);
            Student student = null;
            try
            {
                student = students.Where(s => s.Id == id).First();
            }
            catch (Exception e)
            {
                Console.WriteLine("No such student");
            }
            if(student != null)
            {
                Console.WriteLine("The studnets detais: ");
                Console.WriteLine(student);
                Console.WriteLine("Are you sure you want to delete");
                string choice = Console.ReadLine();
                if(choice.ToUpper() == "YES")
                {
                    cmdDeleteStudent = new SqlCommand("proc_DeleteStudnet", conn);
                    cmdDeleteStudent.CommandType = CommandType.StoredProcedure;
                    cmdDeleteStudent.Parameters.AddWithValue("@sid", id);
                    try
                    {
                        conn.Open();
                        int iResult = cmdDeleteStudent.ExecuteNonQuery();
                        if (iResult > 0)
                            Console.WriteLine("Student deleted");
                        else
                            Console.WriteLine("No record was deleted");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("-------------------");
                        Console.WriteLine(e.StackTrace);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                    Console.WriteLine("Okay....");
            }
            else
                Console.WriteLine("No such student");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.InsertStudentToDatabase();
            //program.GetStudentsDataFromDatabase();
            //program.PrintStudents();
            //program.UpdateStudentNameUsingSP();
            program.GetStudentsDataFromDatabase();
            program.PrintStudents();
            program.DeleteStudentRecordFromDatabase();
            program.GetStudentsDataFromDatabase();
            program.PrintStudents();
            Console.ReadKey();
        }
    }
}
