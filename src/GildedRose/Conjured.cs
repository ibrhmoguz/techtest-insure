namespace GildedRoseKata
{
    public class Conjured : Item
    {
        public Conjured()
        {
            Name = "Conjured Mana Cake";
        }
        
        public void UpdateQuality()
        {
            if (Quality > 0)
            {
                if (Name == "Conjured Mana Cake")
                {
                    Quality -= 2;
                }
            }

            SellIn = SellIn - 1;

            if (SellIn < 0)
            {
                if (Quality > 0)
                {
                    Quality = Quality - 1;
                }
            }
        }
    }
}
