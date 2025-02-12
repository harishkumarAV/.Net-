// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using DependencyInjectionProject;
using DependencyInjectionProject.Interfaces;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        // Create a service collection
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);

        // Build the service provider
        var serviceProvider = serviceCollection.BuildServiceProvider();

        // Resolve and run the application
        var app = serviceProvider.GetService<App>();
        app.run();
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        // Register services
        services.AddTransient<IMessageWriter, ConsoleMessageWriter>();
        services.AddTransient<App>();
    }
}