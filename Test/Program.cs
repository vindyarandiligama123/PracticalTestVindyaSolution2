using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>();

               employees.Add(new ContractEmployee());
               employees.Add(new ContractEmployee());
               employees.Add(new PermanentEmployee());
               employees.Add(new PermanentEmployee());
               employees.Add(new PermanentEmployee());

            var salary = new Salary();
            salary.CalcSalary(employees);
        }

        //public List<Employee> GetEmpData()
        //{
        //    List<Employee> employees = new List<Employee>();

        //    employees.Add(new Employee { Name = "John", HoursWorked = 1, OTHoursWorked = 1, Salary = 1000 });
        //    employees.Add(new Employee { Name = "John", HoursWorked = 1, OTHoursWorked = 1, Salary = 1000 });
        //    employees.Add(new Employee { Name = "John", HoursWorked = 1, OTHoursWorked = 1, Salary = 1000 });
        //    employees.Add(new Employee { Name = "John", HoursWorked = 1, OTHoursWorked = 1, Salary = 1000 });
        //    employees.Add(new Employee { Name = "John", HoursWorked = 1, OTHoursWorked = 1, Salary = 1000 });

        //    return employees;

        //}

        //public int Total(int num1, int num2)
        //{
        //    int sum = num1 + num2;

        //    return sum;

        //}
        
        //public string Name(string name1, string name2)
        //{
        //    string fullName = name1 + name2;

        //    return fullName;
        //}
    }
}
