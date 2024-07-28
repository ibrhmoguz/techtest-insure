using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i] is AgedBrie agedBrie)
                {
                    agedBrie.UpdateQuality();
                }
                else if (Items[i] is BackstagePasses backstagePasses)
                {
                    backstagePasses.UpdateQuality();
                }
                else if (Items[i] is Sulfuras sulfuras)
                {
                    sulfuras.UpdateQuality();
                }
                else if (Items[i] is Conjured conjured)
                {
                    conjured.UpdateQuality();
                }
                else
                {
                    Items[i].UpdateQuality();
                }
            }
        }
    }
}