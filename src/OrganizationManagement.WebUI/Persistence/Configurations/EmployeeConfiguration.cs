using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizationManagement.WebUI.Extensions;
using OrganizationManagement.WebUI.Models.Entities;

namespace OrganizationManagement.WebUI.Persistence.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ApplyEntityDefaults();
            builder.Property(property => property.Nik)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(property => property.Name)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(property => property.Email)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(property => property.Gender)
                .IsRequired()
                .HasMaxLength(10)
                .HasConversion<string>();
            builder.HasMany(property => property.Positions)
                .WithOne(property => property.Employee);
        }
    }
}
