using Microsoft.EntityFrameworkCore;
using OrganizationManagement.WebUI.Abstraction;
using OrganizationManagement.WebUI.Models.Entities;

namespace OrganizationManagement.WebUI.Services
{
    public class PositionService : ServiceBase<Position>
    {
        public PositionService(DbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
