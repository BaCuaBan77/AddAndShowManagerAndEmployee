using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLong8A
{
    class SalesPerson:Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson(string nameVal, DateTime dateOfBirthVal,
            int nextSalesNumber)
            : base(nameVal, dateOfBirthVal)
        {
            SalesNumber = nextSalesNumber;
        }
    }
}

