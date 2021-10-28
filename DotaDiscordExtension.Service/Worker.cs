using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DotaDiscordExtension.Core.Interfaces;
using DotaDiscordExtension.Service.Services;

namespace DotaDiscordExtension.Service
{
    public class Worker : BackgroundService
    {
        private readonly IDiscordProvider _discord;

        private bool _isStarted = false;

        public Worker(IDiscordProvider discord)
        {
            _discord = discord;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                switch (await CheckProcess())
                {
                    case true when !_isStarted:
                        _discord.Start();
                        _isStarted = true;
                        break;
                    case false when _isStarted:
                        _discord.Stop();
                        _isStarted = false;
                        break;
                }
                await Task.Delay(5000, stoppingToken);
            }
        }

        private async Task<bool> CheckProcess() =>
            await Task.Run(() =>
                Process.GetProcesses().FirstOrDefault(process =>
                    process.ProcessName.Equals("dota2", StringComparison.Ordinal)) is not null);

        public override void Dispose()
        {
            _discord.Dispose();
            base.Dispose();
        }
    }
}
