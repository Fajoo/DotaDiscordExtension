using System.Threading.Tasks;

namespace DotaDiscordExtension.UI.Infrastructure
{
    internal delegate Task ActionAsync();

    internal delegate Task ActionAsync<in T>(T parameter);
}