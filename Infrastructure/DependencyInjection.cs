

using Application.Abstractions.Data;
using Domain.Users;
using Infrastructure.Postgresql.Data;
using Infrastructure.Postgresql.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("default");
        services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options => options.UseNpgsql(connectionString));
        services.AddScoped<IUserRepository, UserRepository>();
    }
}