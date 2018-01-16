using GildedRose.Logic.Adjusters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Logic
{
    public class ItemProcessor
    {
        AdjusterFactory factory = new AdjusterFactory();

        public Item UpdateItem(Item input)
        {
            var adjuster = factory.GetAdjuster(input.Name); 
            return adjuster.AdjustItem(input);
        }
    }




}
