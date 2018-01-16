using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Logic.Adjusters
{
    public interface IAdjuster
    {
        Item AdjustItem(Item input);
    }
}
