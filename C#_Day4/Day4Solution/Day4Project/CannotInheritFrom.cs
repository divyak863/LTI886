using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Project
{
    sealed class CannotInheritFrom
    {
        public int Age { get; set; }

        public CannotInheritFrom()
        {
        }

        public CannotInheritFrom(int age)
        {
            Age = age;
        }
    }
}
