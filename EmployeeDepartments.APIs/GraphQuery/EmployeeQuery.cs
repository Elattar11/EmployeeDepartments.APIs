using EmployeeDepartments.APIs.Services;
using EmployeeDepartments.APIs.Types;
using GraphQL;
using GraphQL.Types;

namespace EmployeeDepartments.APIs.GraphQuery
{
    public class EmployeeQuery : ObjectGraphType
    {
        public EmployeeQuery(IEmployeeService employeeService)
        {
            Field<ListGraphType<EmployeeDetailsType>>(Name = "Employees", resolve: x => employeeService.GetEmployees());
            Field<ListGraphType<EmployeeDetailsType>>(Name = "Employee",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: x => employeeService.GetEmployee(x.GetArgument<int>("id")));
        }
    }
}
