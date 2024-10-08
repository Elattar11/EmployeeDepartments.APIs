using EmployeeDepartments.APIs.Models;

namespace EmployeeDepartments.APIs.Services
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService()
        {
            
        }

        #region Generate new List Of Employees
        private List<Employee> employees = new List<Employee>
        {
            new Employee(1, "Tom", 25, 1),
            new Employee(2, "Henry", 28, 1),
            new Employee(3, "Steve", 30, 2),
            new Employee(4, "Ben", 26, 2),
            new Employee(5, "John", 35, 3),

        };
        #endregion

        #region Generate New List of Departments

        private List<Department> departments = new List<Department>
        {
            new Department(1, "IT"),
            new Department(2, "Finance"),
            new Department(3, "HR"),
        };

        #endregion

        public List<EmployeeDetails> GetEmployee(int empId)
        {
            return employees.Where(emp => emp.Id == empId).Select(emp => new EmployeeDetails
            {
                Id = emp.Id,
                Name = emp.Name,
                Age = emp.Age,
                DeptName = departments.First(d => d.Id == emp.DeptId).Name,
            }).ToList();
        }

        public List<EmployeeDetails> GetEmployees()
        {
            return employees.Select(emp => new EmployeeDetails
            {
                Id = emp.Id,
                Name = emp.Name,
                Age = emp.Age,
                DeptName = departments.First(d => d.Id == emp.DeptId).Name,
            }).ToList();
        }

        public List<EmployeeDetails> GetEmployeesByDepartment(int deptId)
        {
            return employees.Where(emp => emp.DeptId == deptId).Select(emp => new EmployeeDetails
            {
                Id = emp.Id,
                Name = emp.Name,
                Age = emp.Age,
                DeptName = departments.First(d => d.Id == deptId).Name,
            }).ToList();
        }
    }
}
