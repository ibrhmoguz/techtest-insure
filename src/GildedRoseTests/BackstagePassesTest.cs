using Xunit;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class BackstagePassesTest
    {
        [Theory]
        [InlineData(11, 15)]
        [InlineData(12, 22)]
        [InlineData(20, 11)]
        public void IncreasesQualityByOne(int quality, int sellIn)
        {
            var item = new BackstagePasses {Quality = quality, SellIn = sellIn};
            item.UpdateQuality();
            Assert.Equal(quality + 1, item.Quality);
        }

        [Theory]
        [InlineData(10, 10)]
        [InlineData(3, 8)]
        [InlineData(12, 7)]
        public void IncreasesQualityByTwo(int quality, int sellIn)
        {
            var item = new BackstagePasses {Quality = quality, SellIn = sellIn};
            item.UpdateQuality();
            Assert.Equal(quality + 2, item.Quality);
        }

        [Theory]
        [InlineData(5, 5)]
        [InlineData(10, 3)]
        [InlineData(20, 2)]
        public void IncreasesQualityByThree(int quality, int sellIn)
        {
            var item = new BackstagePasses {Quality = quality, SellIn = sellIn};
            item.UpdateQuality();
            Assert.Equal(quality + 3, item.Quality);
        }

        [Fact]
        public void DropsQualityToZero()
        {
            var passes = new BackstagePasses
            {
                SellIn = 0,
                Quality = 10
            };

            passes.UpdateQuality();
            Assert.Equal(0, passes.Quality);
        }
    }
}