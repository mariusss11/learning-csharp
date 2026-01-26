using Avalonia;
using Avalonia.ReactiveUI;
using Microsoft.EntityFrameworkCore;
using System;
using QuizzApp.Data;  // Add this at the top


namespace QuizzApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            // --- Temporary DB check ---

            using var context = AppDbContext.CreateDefault();
            Console.WriteLine("Database: " + context.Database.GetDbConnection().Database);
            Console.WriteLine("Data Source: " + context.Database.GetDbConnection().DataSource);

            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                         .UsePlatformDetect()
                         .LogToTrace()
                         .UseReactiveUI()
                         .WithInterFont();
    }
}
