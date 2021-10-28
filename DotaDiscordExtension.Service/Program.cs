using DotaDiscordExtension.Core;
using DotaDiscordExtension.Core.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DotaDiscordExtension.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseWindowsService(options =>
                {
                    options.ServiceName = "DotaDiscordExtension";
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<IDiscordProvider, DiscordProvider>();
                    services.AddHostedService<Worker>();
                });
    }
}
