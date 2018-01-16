using GildedRose.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildedRose.Utility
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please specify an input file containing one or more items");
            }
            else
            {
                var fileContents = System.IO.File.ReadAllLines(args[0]);

                var adjuster = new InventoryAdjuster();
                var output = adjuster.Update(fileContents.ToList());

                Console.WriteLine("--- Updated Output ---\r\n");
                foreach (var line in output)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine("\r\nPress any key to end");
            Console.ReadKey();
        }
    }
}
