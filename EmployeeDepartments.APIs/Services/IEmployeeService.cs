using EmployeeDepartments.APIs.Models;

namespace EmployeeDepartments.APIs.Services
{
    public interface IEmployeeService
    {
        //Get All Employees
        public List<EmployeeDetails> GetEmployees();

        //Get Employee By ID
        public List<EmployeeDetails> GetEmployee(int empId);

        //Get Employee By Department Name
        public List<EmployeeDetails> GetEmployeesByDepartment(int deptId);
    }
}
