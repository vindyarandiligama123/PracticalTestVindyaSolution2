using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Employee
    {
        public string Name { get; set; }
        //public string Category { get; set; }
        public int HoursWorked { get; set; }
        public int OTHoursWorked { get; set; }
        public int Salary { get; set; }
        

        public virtual void Calc()
        {

        }

    }
}
