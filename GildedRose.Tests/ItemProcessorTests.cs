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
    public class ItemProcessorTests
    {
        ItemProcessor processor;

        [SetUp]
        public void Setup()
        {
            processor = new ItemProcessor();
        }

        [TestCase("Aged Brie", 1, 1, 2)]
        [TestCase("Backstage passes", -1, 2, 0)]
        [TestCase("Backstage passes", 9, 2, 4)]      
        [TestCase("Normal Item", 2, 2, 1)]
        [TestCase("Conjured", 2, 2, 0)]
        [TestCase("Conjured", -1, 5, 1)]
        public void ValuesUpdateCorrectly(string itemName, int initSellIn, int initQuality, int expectedQuality)
        {
            var item = new Item { Name = itemName, Quality = initQuality, SellIn = initSellIn };
            var update = processor.UpdateItem(item);

            Assert.AreEqual(itemName, update.Name, "Name should not have changed");
            Assert.AreEqual(initSellIn - 1, update.SellIn, "SellIn value not correctly updated");
            Assert.AreEqual(expectedQuality, update.Quality, "Quality value not correctly updated");
            Assert.IsTrue(update.IsValid, "Item should be marked Valid");
        }

        [TestCase("INVALID ITEM", 2, 2)]
        [TestCase("", 12, 24)]
        [TestCase("!@#$$$%%^", -12, -12)]
        public void InvalidItemsHaveNoValue(string itemName, int initSellIn, int initQuality)
        {
            var item = new Item { Name = itemName, Quality = initQuality, SellIn = initSellIn };
            var update = processor.UpdateItem(item);

            Assert.AreEqual("NO SUCH ITEM", update.Name, "Name should have been replaced");
            Assert.AreEqual(0, update.Quality, "Invalid items have no Quality value");
            Assert.AreEqual(0, update.SellIn, "Invalid items have no SellIn value");
            Assert.IsFalse(update.IsValid, "Item should be marked Invalid");
        }

        [TestCase(2, 2)]
        [TestCase(5, 50)]
        public void SulfurasDoesNotNormallyAdjust(int initSellIn, int initQuality)
        {
            var item = new Item { Name = "Sulfuras", Quality = initQuality, SellIn = initSellIn };
            var update = processor.UpdateItem(item);

            Assert.AreEqual(initSellIn, update.SellIn, "SellIn value should not change");
            Assert.AreEqual(initQuality, update.Quality, "Quality value should not change");
        }

        [TestCase("Normal Item", -1, 55)]
        [TestCase("Aged Brie", 5, 60)]
        [TestCase("Sulfuras", 6, 55)]
        [TestCase("Backstage passes", 2, 49)]
        public void ValuesCapAt50(string itemName, int initSellIn, int initQuality)
        {
            var item = new Item { Name = itemName, Quality = initQuality, SellIn = initSellIn };
            var update = processor.UpdateItem(item);

            Assert.AreEqual(50, update.Quality, "Quality should have been set to 50");
        }
    }
}
