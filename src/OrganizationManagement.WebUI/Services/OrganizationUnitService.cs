using Microsoft.EntityFrameworkCore;
using OrganizationManagement.WebUI.Abstraction;
using OrganizationManagement.WebUI.Models.Entities;

namespace OrganizationManagement.WebUI.Services
{
    public class OrganizationUnitService : ServiceBase<OrganizationUnit>
    {
        public OrganizationUnitService(DbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
