using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeDepartments.APIs.GraphQuery
{
    public class EmployeeDetailsSchema : Schema
    {
        public EmployeeDetailsSchema(IServiceProvider provide) : base(provide)
        {
            Query = provide.GetRequiredService<EmployeeQuery>();
        }
    }
}
