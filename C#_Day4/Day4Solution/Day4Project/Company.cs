using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Project
{
    class Company
    {
        Employee[] employees;
        Company()
        {
            employees = new Employee[3];
        }
        void AddEmployees()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee((100+i),("XYZ "+i));
            }
        }
        void PrintEmployees()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
        static void Main(string[] args)
        {
            Company company = new Company();
            company.AddEmployees();
            company.PrintEmployees();
            Console.ReadKey();
        }
    }
}
