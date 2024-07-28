using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new AgedBrie {SellIn = 2, Quality = 0 },
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Sulfuras { SellIn = 0, Quality = 80 },
                new Sulfuras { SellIn = -1, Quality = 80 },
                new BackstagePasses { SellIn = 15, Quality = 20 },
                new BackstagePasses { SellIn = 10, Quality = 49 },
                new BackstagePasses { SellIn = 5, Quality = 49 },
                new Conjured { SellIn = 3, Quality = 6 }
            };

            var app = new GildedRose(items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < items.Count; j++)
                {
                    Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
                }

                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}