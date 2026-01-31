using crud_application.Data;
using crud_application.Services;
using crud_application.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace crud_application.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddCommonServices(this IServiceCollection collection)
    {
        
        // Register DB Context with PostgreSQL provider
        collection.AddDbContext<ApplicationDbContext>(options =>
        {
            var connectionString = ConfigurationHelper.GetConnectionString("DefaultConnection");
            options.UseNpgsql(connectionString);
        });
        
        // Register View Models
        collection.AddTransient<MainWindowViewModel>();
            
        // Register Services
        collection.AddTransient<ICustomerService, CustomerService>();
        
    }
}