using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizationManagement.WebUI.Extensions;
using OrganizationManagement.WebUI.Models.Entities;

namespace OrganizationManagement.WebUI.Persistence.Configurations
{
    public class OrganizationUnitConfiguration : IEntityTypeConfiguration<OrganizationUnit>
    {
        public void Configure(EntityTypeBuilder<OrganizationUnit> builder)
        {
            builder.ApplyEntityDefaults();
            builder.Property(property => property.Name)
                .IsRequired()
                .HasMaxLength(150);
            builder.HasOne(property => property.UnitType)
                .WithMany(property => property.OrganizationUnits)
                .HasForeignKey(property => property.UnitTypeId);
            builder.HasMany(property => property.Positions)
                .WithOne(property => property.OrganizationUnit);
            builder.HasMany(property => property.Childs)
                .WithOne(property => property.Parent)
                .HasForeignKey(property => property.ParentId);
        }
    }
}
