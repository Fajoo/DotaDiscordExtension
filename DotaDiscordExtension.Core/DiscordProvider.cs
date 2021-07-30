using System;
using System.Diagnostics;
using DiscordRPC;
using DotaDiscordExtension.Core.Interfaces;
using DotaDiscordExtension.Core.Models;

namespace DotaDiscordExtension.Core
{
    public class DiscordProvider : IDiscordProvider
    {
        private readonly Dota2Provider _dota2Provider;
        private DiscordRpcClient _discordClient;

        private long _time = 0;

        public DiscordProvider() => _dota2Provider = new Dota2Provider();

        public bool Start()
        {
            _discordClient = new DiscordRpcClient("700756138488103013");

            if(!_discordClient.IsInitialized)
                _discordClient.Initialize();

            //!ToDo UpdateSpeed

            _dota2Provider.StateGame += Dota2ProviderOnStateGame;

            return _dota2Provider.Start();
        }

        private void Dota2ProviderOnStateGame(Dota2Provider provider, DotaModel model)
        {
            var timeNow = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            if (timeNow - _time < 3) return;

            Console.WriteLine(model.GameState);

            _discordClient.SetPresence(new RichPresence
            {
                Details = model.KDA.ToString(),
                State = model.Team,
                Assets = new Assets
                {
                    LargeImageKey = "draft",
                    LargeImageText = $"{model.Hero} (Lvl: {model.Lvl})"
                }
            });

            _time = timeNow;
        }

        public void Stop() => Dispose();

        public void Dispose()
        {
            _discordClient.Deinitialize();
            _dota2Provider.Stop();
        }
    }
}