using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizationManagement.WebUI.Extensions;
using OrganizationManagement.WebUI.Models.Entities;

namespace OrganizationManagement.WebUI.Persistence.Configurations
{
    public class JobFamilyConfiguration : IEntityTypeConfiguration<JobFamily>
    {
        public void Configure(EntityTypeBuilder<JobFamily> builder)
        {
            builder.ApplyEntityDefaults();
            builder.Property(property => property.Name)
                .IsRequired()
                .HasMaxLength(150);
            builder.HasMany(property => property.Jobs)
                .WithOne(property => property.JobFamily);
        }
    }
}
