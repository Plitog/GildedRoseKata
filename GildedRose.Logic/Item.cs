namespace GildedRose.Logic
{
    public class Item
    {
        public Item()
        {
            IsValid = true;
        }

        public string Name { get; set; }
        
        /// Number of days left to sell the item
        public int SellIn { get; set; }
        
        /// Current value of the item
        public int Quality { get; set; }

        public bool IsValid { get; set; }
    }
}
