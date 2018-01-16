using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Logic.Adjusters
{
    public class SulfurasAdjuster : IAdjuster
    {
        public Item AdjustItem(Item input)
        {
            return new Item { Name = input.Name, Quality = input.Quality, SellIn = input.SellIn };
        }
    }
}
