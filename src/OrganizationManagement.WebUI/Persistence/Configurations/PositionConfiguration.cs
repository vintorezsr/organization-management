using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizationManagement.WebUI.Extensions;
using OrganizationManagement.WebUI.Models.Entities;

namespace OrganizationManagement.WebUI.Persistence.Configurations
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ApplyEntityDefaults();
            builder.Property(property => property.Name)
                .IsRequired()
                .HasMaxLength(150);
            builder.HasOne(property => property.Job)
                .WithMany(property => property.Positions)
                .HasForeignKey(property => property.JobId);
            builder.HasOne(property => property.OrganizationUnit)
                .WithMany(property => property.Positions)
                .HasForeignKey(property => property.OrganizationUnitId);
            builder.HasMany(property => property.Employees)
                .WithOne(property => property.Position);
        }
    }
}
