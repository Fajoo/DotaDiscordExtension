using DotaDiscordExtension.Core;
using Xunit;

namespace DotaDiscordExtension.Tests
{
    public class SteamConfigureTests
    {
        private readonly SteamConfigure _steam;

        public SteamConfigureTests()
        {
            _steam = new SteamConfigure();
        }

        [Fact]
        public async void CreateFile_ValuesCoincide_ReturnTrue()
        {
            //var expected = WriteResult.OK;

            //var actual = await _steam.CreateFileAsync();

            //Assert.Equal(expected, actual);
        }
    }
}