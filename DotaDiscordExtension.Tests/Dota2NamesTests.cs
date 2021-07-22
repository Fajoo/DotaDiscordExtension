using DotaDiscordExtension.Core.Resources;
using Xunit;

namespace DotaDiscordExtension.Tests
{
    public class Dota2NamesTests
    {
        [Fact]
        public void IsCorrectName_ValuesCoincide_ReturnTrue()
        {
            var expected = "Underlord";

            var actual = Dota2Names.GetHeroName("npc_dota_hero_abyssal_underlord");

            Assert.Equal(expected, actual);
        }
    }
}