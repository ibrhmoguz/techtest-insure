using Xunit;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class ConjuredTest
    {
        [Theory]
        [InlineData(8,5)]
        [InlineData(4,4)]
        [InlineData(10,8)]
        public void DecreasesQualityByTwo(int quality, int sellIn)
        {
            var item = new Conjured { Quality = quality, SellIn = sellIn };
            item.UpdateQuality();
            Assert.Equal(quality - 2, item.Quality);
        }

        [Theory]
        [InlineData(50,5)]
        [InlineData(50,1)]
        [InlineData(50,0)]
        public void DecreasesSellInByOne(int quality, int sellIn)
        {
            var item = new Conjured { Quality = quality, SellIn = sellIn };
            item.UpdateQuality();
            Assert.Equal(sellIn - 1, item.SellIn);
        }

        [Theory]
        [InlineData(5,0)]
        [InlineData(10,-1)]
        [InlineData(20,-10)]
        public void DecreasesQualityByThree(int quality, int sellIn)
        {
            var item = new Conjured { Quality = quality, SellIn = sellIn };
            item.UpdateQuality();
            Assert.Equal(quality - 3, item.Quality);
        }
    }
}
