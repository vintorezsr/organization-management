using Microsoft.EntityFrameworkCore;
using OrganizationManagement.WebUI.Abstraction;
using OrganizationManagement.WebUI.Models.Entities;

namespace OrganizationManagement.WebUI.Services
{
    public class JobService : ServiceBase<Job>
    {
        public JobService(DbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
