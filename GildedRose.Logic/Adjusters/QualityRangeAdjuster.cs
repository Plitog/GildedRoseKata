using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Logic.Adjusters
{
    public class QualityRangeAdjuster : IAdjuster
    {
        IAdjuster wrappedAdjuster;
        const int maxQuality = 50;
        const int minQuality = 0;

        public QualityRangeAdjuster(IAdjuster adjuster)
        {
            wrappedAdjuster = adjuster;
        }

        public Item AdjustItem(Item input)
        {
            var partial = wrappedAdjuster.AdjustItem(input);

            if (partial.Quality > maxQuality)
                partial.Quality = maxQuality;
            else if (partial.Quality < minQuality)
                partial.Quality = minQuality;

            return partial;
        }
    }
}
