using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizationManagement.WebUI.Extensions;
using OrganizationManagement.WebUI.Models.Entities;

namespace OrganizationManagement.WebUI.Persistence.Configurations
{
    public class EmployeePositionConfiguration : IEntityTypeConfiguration<EmployeePosition>
    {
        public void Configure(EntityTypeBuilder<EmployeePosition> builder)
        {
            builder.ApplyEntityDefaults();
            builder.HasOne(property => property.Employee)
                .WithMany(property => property.Positions)
                .HasForeignKey(property => property.EmployeeId);
            builder.HasOne(property => property.Position)
                .WithMany(property => property.Employees)
                .HasForeignKey(property => property.PositionId);
        }
    }
}
