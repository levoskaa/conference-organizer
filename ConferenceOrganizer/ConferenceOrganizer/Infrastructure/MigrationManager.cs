using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace Web.Infrastructure
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var isDevelopment = environment == Environments.Development;
            if (!isDevelopment)
            {
                return host;
            }

            using (var scope = host.Services.CreateScope())
            using (var appContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
            {
                try
                {
                    appContext.Database.Migrate();
                }
                catch (Exception e)
                {
                    var services = scope.ServiceProvider;
                    var logger = services.GetRequiredService<ILogger>();
                    logger.LogError(e, "An error occured during running migrations.");
                }
            }
            return host;
        }
    }
}