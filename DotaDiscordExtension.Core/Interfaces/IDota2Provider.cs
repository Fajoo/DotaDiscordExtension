using System;

namespace DotaDiscordExtension.Core.Interfaces
{
    public interface IDota2Provider : IProvider
    {
        public event StateGame StateGame;
    }
}