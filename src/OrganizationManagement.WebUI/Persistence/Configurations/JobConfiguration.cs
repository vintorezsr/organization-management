using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganizationManagement.WebUI.Extensions;
using OrganizationManagement.WebUI.Models.Entities;

namespace OrganizationManagement.WebUI.Persistence.Configurations
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.ApplyEntityDefaults();
            builder.Property(property => property.Name)
                .IsRequired()
                .HasMaxLength(150);
            builder.HasOne(property => property.JobFamily)
                .WithMany(property => property.Jobs)
                .HasForeignKey(property => property.JobFamilyId);
            builder.HasMany(property => property.Positions)
                .WithOne(property => property.Job);
        }
    }
}
