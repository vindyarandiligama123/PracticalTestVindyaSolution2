using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Salary
    {
        public void CalcSalary(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                employee.Calc();
            }
        }
    }
}
