using System;
using DiscordRPC;
using DotaDiscordExtension.Core.Interfaces;
using DotaDiscordExtension.Core.Models;

namespace DotaDiscordExtension.Core
{
    public class DiscordProvider : IDiscordProvider
    {
        private readonly Dota2Provider _dota2Provider;
        private readonly DiscordRpcClient _discordClient;

        //private long _time = 0;

        public DiscordProvider()
        {
            _dota2Provider = new Dota2Provider();

            _discordClient = new DiscordRpcClient("700756138488103013");
        }

        public bool Start()
        {
            if(!_discordClient.IsInitialized)
                _discordClient.Initialize();

            _dota2Provider.StateGame += Dota2ProviderOnStateGame;

            return _dota2Provider.Start();
        }

        private void Dota2ProviderOnStateGame(Dota2Provider provider, DotaModel model)
        {
            //var timeNow = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            //if (timeNow - _time < 3) return;

            Console.WriteLine(DateTime.Now);

            if (model is not null)
                _discordClient.SetPresence(PresenceConfigure.GetPresence(model));
            else
                _discordClient.ClearPresence();

            //_time = timeNow;
        }

        public void Stop() => Dispose();

        public void Dispose()
        {
            _discordClient.ClearPresence();

            _dota2Provider.StateGame -= Dota2ProviderOnStateGame;

            _dota2Provider.Stop();
        }
    }
}