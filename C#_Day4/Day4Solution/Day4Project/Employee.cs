using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Project
{
    class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee() { }
        public Employee(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return "Employee Id : "+Id+" Employee Name "+Name;
        }
    }
}
