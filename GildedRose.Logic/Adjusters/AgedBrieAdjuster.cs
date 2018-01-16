using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Logic.Adjusters
{
    public class AgedBrieAdjuster : IAdjuster
    {
        public Item AdjustItem(Item input)
        {
            var output = new Item
            {
                Name = input.Name,
                SellIn = input.SellIn - 1,
                Quality = input.Quality + 1
            };
            return output;
        }
    }
}
