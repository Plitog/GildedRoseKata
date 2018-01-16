using GildedRose.Logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Tests
{
    [TestFixture]
    public class InventoryAdjusterTests
    {
        [Test]
        public void ExampleTextIsParsed()
        {
            var input = new List<string>
            {
                "Aged Brie 1 1",
                "Backstage passes -1 2",
                "Backstage passes 9 2",
                "Sulfuras 2 2",
                "Normal Item -1 55",
                "Normal Item 2 2",
                "INVALID ITEM 2 2",
                "Conjured 2 2",
                "Conjured -1 5"
            };

            var adjuster = new InventoryAdjuster();
            var output = adjuster.Update(input);

            Assert.AreEqual(input.Count, output.Count, "Output list should have same number of items as input");
        }
    }
}
