using Microsoft.EntityFrameworkCore;
using OrganizationManagement.WebUI.Abstraction;
using OrganizationManagement.WebUI.Models.Entities;

namespace OrganizationManagement.WebUI.Services
{
    public class UnitTypeService : ServiceBase<UnitType>
    {
        public UnitTypeService(DbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
