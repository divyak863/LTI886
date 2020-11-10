using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Project
{
    class Program
    {
        void PrintMenu()
        {
            Company company = new Company();
            company.AddEmployees();
            int iChoice = 0;
            do
            {
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Update Employee details");
                Console.WriteLine("2. Delete an Employee");
                Console.WriteLine("3. Print All Employees");
                Console.WriteLine("4. Print One Employee");
                Console.WriteLine("5. Exit");
                while (!int.TryParse(Console.ReadLine(),out iChoice) || iChoice>4)
                {
                    Console.WriteLine("Invald entry please try again...");
                }
                switch (iChoice)
                {
                    case 1:
                        Console.WriteLine("You can update employee details by enteringthe id");
                        company.UpdateEmployee();
                        break;
                    case 2:
                        Console.WriteLine("You can delete employee details by entering the id");
                        company.DeleteEmployee();
                        break;
                    case 3:
                        Console.WriteLine("All employee details");
                        company.PrintAllEmployees();
                        break;
                    case 4:
                        int id;
                        Console.WriteLine("Please enter the id");
                        while (!int.TryParse(Console.ReadLine(), out id) || id < 1)
                        {
                            Console.WriteLine("Invalid id. Please enter again");
                        }
                        company[id - 1].PrintEmployeeData();
                        break;
                    case 5:
                        Console.WriteLine("Bye bye.......");
                        break;
                    default:
                        Console.WriteLine("Invald entry please try again...");
                        break;
                }

            } while (iChoice!=5);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PrintMenu();
            Console.ReadKey();
        }
    }
}
