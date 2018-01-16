using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Logic.Adjusters
{
    class InvalidItemAdjuster : IAdjuster
    {
        public Item AdjustItem(Item input)
        {
            return new Item { Name = "NO SUCH ITEM", Quality = 0, SellIn = 0, IsValid = false };
        }
    }
}
