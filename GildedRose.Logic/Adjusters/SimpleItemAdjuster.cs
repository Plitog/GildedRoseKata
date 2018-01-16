using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Logic.Adjusters
{
    public class SimpleItemAdjuster : IAdjuster
    {
        int degradeRate;
        public SimpleItemAdjuster(int degradeRate)
        {
            this.degradeRate = degradeRate;
        }

        public Item AdjustItem(Item input)
        {
            var output = new Item
            {
                Name = input.Name,
                SellIn = input.SellIn - 1
            };

            if (input.SellIn > 0)
            {
                output.Quality = input.Quality - degradeRate;
            }
            else
            {
                output.Quality = input.Quality - (2 * degradeRate);
            }

            return output;
        }
    }
}
