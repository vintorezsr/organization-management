using Microsoft.EntityFrameworkCore;
using OrganizationManagement.WebUI.Abstraction;
using OrganizationManagement.WebUI.Models.Entities;

namespace OrganizationManagement.WebUI.Services
{
    public class JobFamilyService : ServiceBase<JobFamily>
    {
        public JobFamilyService(DbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
