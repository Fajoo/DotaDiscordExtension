using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DotaDiscordExtension.Core.Interfaces;
using DotaDiscordExtension.Core.Resources;
using Newtonsoft.Json;

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
            var client = new HttpClient();
            var content =
                await client.GetStringAsync("https://raw.githubusercontent.com/Fajoo/herodata/main/herodata.json", stoppingToken);

            Dota2Names.HeroNames = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);


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
                await Task.Delay(8000, stoppingToken);
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
