using Xunit;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class SulfurasTest
    {
        [Fact]
        public void DoesNotChangeQualityOrSellIn()
        {
            var sulfuras = new Sulfuras { SellIn = 5, Quality = 80 };
            sulfuras.UpdateQuality();
        
            Assert.Equal(5, sulfuras.SellIn);
            Assert.Equal(80, sulfuras.Quality);
        }
    }
}
