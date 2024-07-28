namespace GildedRoseKata
{
    public class BackstagePasses : Item
    {
        public BackstagePasses()
        {
            Name = "Backstage passes to a TAFKAL80ETC concert";
        }

        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                Quality += 1;

                if (SellIn < 11)
                {
                    if (Quality < 50)
                    {
                        Quality += 1;
                    }
                }

                if (SellIn < 6)
                {
                    if (Quality < 50)
                    {
                        Quality += 1;
                    }
                }
            }
            
            SellIn -= 1;

            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }
}