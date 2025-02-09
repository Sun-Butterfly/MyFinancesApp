using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace finances_db;

public class Registrar
{
    public static IServiceCollection AddDatabase(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        return services;
    }
}