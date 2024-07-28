namespace GildedRoseKata
{
    public class Sulfuras : Item
    {
        public Sulfuras()
        {
            Name = "Sulfuras, Hand of Ragnaros";
        }
        
        public override void UpdateQuality()
        {
            // legendary item: never has to be sold or decreases in Quality
        }
    }
}
