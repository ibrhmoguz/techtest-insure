using Xunit;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class AgedBrieTest
    {
        [Theory]
        [InlineData(0,5)]
        [InlineData(4,4)]
        [InlineData(10,8)]
        public void QualityIncreaseOverTime(int quality, int sellIn)
        {
            var item = new AgedBrie { Quality = quality, SellIn = sellIn };
            item.UpdateQuality();
            Assert.Equal(quality + 1, item.Quality);
        }

        [Theory]
        [InlineData(50,5)]
        [InlineData(50,1)]
        [InlineData(50,0)]
        public void QualityDoesNotExceedFifty(int quality, int sellIn)
        {
            var item = new AgedBrie { Quality = quality, SellIn = sellIn };
            item.UpdateQuality();
            Assert.Equal(50, item.Quality);
        }

        [Theory]
        [InlineData(5,0)]
        [InlineData(10,-1)]
        [InlineData(20,-10)]
        public void QualityIncreaseTwiceAfterSellIn(int quality, int sellIn)
        {
            var item = new AgedBrie { Quality = quality, SellIn = sellIn };
            item.UpdateQuality();
            Assert.Equal(quality + 2, item.Quality);
        }
    }
}
