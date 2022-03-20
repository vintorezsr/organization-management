using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using OrganizationManagement.WebUI.Abstraction;

namespace OrganizationManagement.WebUI.Extensions
{
    public static class EntityTypeBuilderExtensions
    {
        public static EntityTypeBuilder<TEntity> ApplyEntityDefaults<TEntity>(this EntityTypeBuilder<TEntity> builder)
            where TEntity : EntityBase<int>
        {
            builder.Property(property => property.Id)
                .ValueGeneratedOnAdd();

            builder.Property(property => property.ModifiedAt)
                .IsConcurrencyToken()
                .ValueGeneratedOnUpdate();

            builder.Property(property => property.CreatedAt)
                .HasDefaultValueSql("SYSDATETIMEOFFSET()")
                .ValueGeneratedOnAdd()
                .Metadata
                .SetAfterSaveBehavior(PropertySaveBehavior.Throw);

            return builder;
        }
    }
}
