using Microsoft.EntityFrameworkCore;
using OrganizationManagement.WebUI.Abstraction;

namespace OrganizationManagement.WebUI.Extensions
{
    public static class DbContextExtensions
    {
        public static async Task SafeAddRangeAsync<TEntity>(
            this DbContext context,
            IEnumerable<TEntity> entities)
            where TEntity : EntityBase<int>
        {
            var entityType = context.Model.FindEntityType(typeof(TEntity))!;
            var tableName = entityType.GetTableName();
            var set = context.Set<TEntity>();
            context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {tableName} ON");
            set.AddRange(entities);
            await context.SaveChangesAsync();
            context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {tableName} OFF");
        }
    }
}
