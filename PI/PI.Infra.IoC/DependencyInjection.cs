using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PI.Domain.Interfaces;
using PI.Infra.Data.Context;
using PI.Infra.Data.Repositories;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace PI.Infra.IoC;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationContext>(options => options.UseMySql(
            "Server=localhost;Port=3306;Database=pi_db;User=root;Password=root;",
            ServerVersion.Parse("8.0.30-mysql" , ServerType.MySql), m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));

        #region repositories 
        
        services.AddScoped<IEnterpriseRepository, EnterpriseRepository>();
        services.AddScoped<ILogsRepository, LogsRepository>();
        services.AddScoped<IMachineRepository, MachineRepository>();
        services.AddScoped<IOutlierRegisterRepository, OutlierRegisterRepository>();
        
        #endregion

    }
}