using DotaDiscordExtension.Core;
using Xunit;

namespace DotaDiscordExtension.Tests
{
    public class SteamSearcherTests
    {
        private readonly SteamSearcher _steam;

        public SteamSearcherTests()
        {
            _steam = new SteamSearcher();
        }

        [Fact]
        public void IsPathsMatch_ValuesCoincide_ReturnTrue()
        {
            var expected = @"D:\steam";

            var actual = _steam.FindSteamInstallPath();

            Assert.Equal(expected, actual);
        }
    }
}