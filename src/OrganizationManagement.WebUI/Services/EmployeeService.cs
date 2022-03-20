using Microsoft.EntityFrameworkCore;
using OrganizationManagement.WebUI.Abstraction;
using OrganizationManagement.WebUI.Models.Entities;

namespace OrganizationManagement.WebUI.Services
{
    public class EmployeeService : ServiceBase<Employee>
    {
        public EmployeeService(DbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
