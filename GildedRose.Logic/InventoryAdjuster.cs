using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Logic
{
    public class InventoryAdjuster
    {
        public List<string> Update(List<string> inventory)
        {
            var parser = new ItemParser();
            var processor = new ItemProcessor();

            var output = new List<string>();

            foreach (var i in inventory)
            {
                var item = parser.Parse(i);
                var updated = processor.UpdateItem(item);

                if (updated.IsValid)
                    output.Add($"{updated.Name} {updated.SellIn} {updated.Quality}");
                else
                    output.Add(updated.Name);
            }

            return output;
        }
    }
}
