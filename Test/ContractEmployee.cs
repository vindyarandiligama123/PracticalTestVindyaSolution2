using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class ContractEmployee : Employee
    {
        public override void Calc()
        {
            int contractSalary = this.HoursWorked * 5;
            Console.WriteLine(contractSalary);
        }




    }
}
