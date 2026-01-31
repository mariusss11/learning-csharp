using System;
using Microsoft.Extensions.Configuration;

namespace crud_application;

public static class ConfigurationHelper
{
    private static IConfigurationRoot? _configuration;

    // Lazy initialization
    private static IConfigurationRoot Configuration
    {
        get
        {
            if (_configuration == null)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory) // ensures it looks in bin/Debug/net9.0
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                _configuration = builder.Build();
            }

            return _configuration;
        }
    }

    // Returns a connection string by name
    public static string GetConnectionString(string name)
    {
        var connStr = Configuration.GetConnectionString(name);

        if (string.IsNullOrWhiteSpace(connStr))
            throw new InvalidOperationException($"Connection string '{name}' not found in appsettings.json.");

        return connStr;
    }
}