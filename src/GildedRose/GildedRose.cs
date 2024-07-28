﻿using System.Collections.Generic;

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
                else
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            if (Items[i].Name == "Conjured Mana Cake")
                            {
                                Items[i].Quality -= 2;
                            }
                            else
                            {
                                Items[i].Quality = Items[i].Quality - 1;
                            }
                        }
                    }

                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                    {
                        Items[i].SellIn = Items[i].SellIn - 1;
                    }

                    if (Items[i].SellIn < 0)
                    {
                        if (Items[i].Quality > 0)
                        {
                            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                            {
                                Items[i].Quality = Items[i].Quality - 1;
                            }
                        }
                    }
                }
            }
        }
    }
}