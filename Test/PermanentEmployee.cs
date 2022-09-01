using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class PermanentEmployee : Employee
    {
        public override void Calc()
        {
            int permanentSalary = this.Salary + (this.OTHoursWorked * 2);
            Console.WriteLine(permanentSalary);
        }
    }
}
