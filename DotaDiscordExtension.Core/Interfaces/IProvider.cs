using System;

namespace DotaDiscordExtension.Core.Interfaces
{
    public interface IProvider : IDisposable
    {
        public bool Start();

        public void Stop();
    }
}