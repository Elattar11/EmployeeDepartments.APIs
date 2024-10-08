using EmployeeDepartments.APIs.Models;
using GraphQL.Types;

namespace EmployeeDepartments.APIs.Types
{
    public class EmployeeDetailsType : ObjectGraphType<EmployeeDetails>
    {
        public EmployeeDetailsType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Age);
            Field(x => x.DeptName);
        }
    }
}
