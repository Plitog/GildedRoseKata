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
    public class ItemParserTests
    {
        [TestCase("Aged Brie 1 1", "Aged Brie", 1, 1)]
        [TestCase("Backstage passes -1 2", "Backstage passes", -1, 2)]
        [TestCase("Sulfuras 2 2", "Sulfuras", 2, 2)]
        public void ItemsParseCorrectly(string input, string expectedName, int expectedSellIn, int expectedQuality)
        {
            ItemParser parser = new ItemParser();
            var item = parser.Parse(input);

            Assert.AreEqual(expectedName, item.Name, "Name should match expected.");
            Assert.AreEqual(expectedQuality, item.Quality, "Quality should match expected.");
            Assert.AreEqual(expectedSellIn, item.SellIn, "SellIn should match expected.");
        }
    }
}
