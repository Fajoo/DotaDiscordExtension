using System;

namespace DotaDiscordExtension.Core.Interfaces
{
    public interface IDota2Provider : IDisposable
    {
        public event StateGame StateGame;

        public bool Start();

        public void Stop();
    }
}