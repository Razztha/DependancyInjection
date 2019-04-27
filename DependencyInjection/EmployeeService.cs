using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            Employee emp1 = new Employee() { EmployeeId = 1, EmployeeName = "Rasitha", Telephone = "119" };
            Employee emp2 = new Employee() { EmployeeId = 1, EmployeeName = "Kamal", Telephone = "118" };
            employeeList.Add(emp1);
            employeeList.Add(emp2);

            return employeeList;
        }
    }
}
