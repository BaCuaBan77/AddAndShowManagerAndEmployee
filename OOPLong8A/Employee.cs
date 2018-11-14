using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLong8A
{
    class Employee
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Employee(string nextName, DateTime nextDateOfBirth)
        {
            Name = nextName;
            DateOfBirth = nextDateOfBirth;
        }
    }
}
