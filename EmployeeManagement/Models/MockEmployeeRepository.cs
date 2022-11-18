using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
            new Employee() { Id=1,Name="nika",Department=Dept.It,Email="nika@gmail.com"},
            new Employee() { Id = 2, Name = "luka", Department = Dept.Hr, Email = "luka@gmail.com" },
            new Employee() { Id = 3, Name = "irma", Department = Dept.Finance, Email = "irma@gmail.com" },
            new Employee() { Id = 4, Name = "lasha", Department = Dept.It, Email = "lasha@gmail.com" }
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }
    }
}
