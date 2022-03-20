using Microsoft.EntityFrameworkCore;
using OrganizationManagement.WebUI.HostedService;
using OrganizationManagement.WebUI.Persistence;
using OrganizationManagement.WebUI.Services;

namespace OrganizationManagement.WebUI.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddService(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MainEntities");
            serviceCollection.AddDbContextFactory<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            serviceCollection.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            serviceCollection.AddScoped<DbContext>(options => options.GetRequiredService<ApplicationDbContext>());
            serviceCollection.AddHostedService<StartupHostedService>();
            serviceCollection.AddTransient<EmployeeService>();
            serviceCollection.AddTransient<JobFamilyService>();
            serviceCollection.AddTransient<JobService>();
            serviceCollection.AddTransient<OrganizationUnitService>();
            serviceCollection.AddTransient<PositionService>();
            serviceCollection.AddTransient<UnitTypeService>();

            return serviceCollection;
        }
    }
}
