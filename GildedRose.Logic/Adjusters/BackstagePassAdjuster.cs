using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Logic.Adjusters
{
    public class BackstagePassAdjuster : IAdjuster
    {
        public Item AdjustItem(Item input)
        {
            var output = new Item
            {
                Name = input.Name,
                SellIn = input.SellIn - 1,
                Quality = input.Quality
            };

            if (output.SellIn > 10)
                output.Quality += 1;
            else if (output.SellIn > 5)
                output.Quality += 2;
            else if (output.SellIn > 0)
                output.Quality += 3;
            else
                output.Quality = 0;

            return output;
        }
    }
}
