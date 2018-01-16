using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Logic
{
    public class ItemParser
    {
        public Item Parse(string itemText)
        {
            // TODO - Handle invalid inputs
            var qualityStart = itemText.LastIndexOf(' ');
            var quality = int.Parse(itemText.Substring(qualityStart));

            var sellInStart = itemText.LastIndexOf(' ', qualityStart - 1);
            var sellIn = int.Parse(itemText.Substring(sellInStart, qualityStart - sellInStart));

            var name = itemText.Substring(0, sellInStart);

            return new Item
            {
                Name = name,
                Quality = quality,
                SellIn = sellIn
            };
        }
    }
}
