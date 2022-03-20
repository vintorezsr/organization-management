using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizationManagement.WebUI.Extensions;
using OrganizationManagement.WebUI.Models.Entities;

namespace OrganizationManagement.WebUI.Persistence.Configurations
{
    public class UnitTypeConfiguration : IEntityTypeConfiguration<UnitType>
    {
        public void Configure(EntityTypeBuilder<UnitType> builder)
        {
            builder.ApplyEntityDefaults();
            builder.Property(property => property.Name)
                .IsRequired()
                .HasMaxLength(150);
            builder.HasMany(property => property.OrganizationUnits)
                .WithOne(property => property.UnitType);
        }
    }
}
