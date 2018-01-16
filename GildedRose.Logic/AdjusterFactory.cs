using GildedRose.Logic.Adjusters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Logic
{
    public class AdjusterFactory
    {
        public IAdjuster GetAdjuster(string itemName)
        {
            IAdjuster adjuster;
            switch (itemName.ToLower())
            {
                case "sulfuras":
                    adjuster = new SulfurasAdjuster();
                    break;
                case "normal item":
                    adjuster = new SimpleItemAdjuster(1);
                    break;
                case "conjured":
                    adjuster = new SimpleItemAdjuster(2);
                    break;
                case "aged brie":
                    adjuster = new AgedBrieAdjuster();
                    break;
                case "backstage passes":
                    adjuster = new BackstagePassAdjuster();
                    break;
                default:
                    adjuster = new InvalidItemAdjuster();
                    break;
            }

            return new QualityRangeAdjuster(adjuster);
        }
    }

}
