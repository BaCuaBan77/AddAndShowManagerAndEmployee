using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLong8A
{
    class Manager:Employee
    {
        public int StockOption { get; set; }

        public Manager(string nameVal, DateTime dateOfBirthVal,
            int nextStockOption)
            : base(nameVal, dateOfBirthVal)
        {
            StockOption = nextStockOption;
        }
    }
}
