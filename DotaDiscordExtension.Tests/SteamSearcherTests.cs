using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public async void GetLibs_CollectionsCoincide_ReturnTrue()
        {
            var expected = new List<string>{ @"D:\steam", @"C:\SteamLibrary" };

            var actual = await _steam.GetLibInstall();

            Assert.Equal(expected, actual.Where(i => i!= null));
        }

        [Fact]
        public async void GetPathToDota_ValuesCoincide_ReturnTrue()
        {
            var expected = "D:\\steam\\steamapps\\common\\dota 2 beta";

            var actual = await _steam.GetPathToDota();

            Assert.Equal(expected, actual);
        }
    }
}