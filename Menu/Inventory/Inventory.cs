using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Inventory
    {
        

        public Inventory()
        {
            
        }

        public void AccessInventory(Inventory inventory)
        {
            Console.WriteLine();
            Console.WriteLine("---- Inventory ----");
            Console.WriteLine();
            Console.WriteLine($"Gold: {Player.Gold}");
            Console.WriteLine();
            Console.WriteLine("- Armor");
            Console.WriteLine("- Crafting Equipment");
            Console.WriteLine("- Food");
            Console.WriteLine("- Gear");
            Console.WriteLine("- Magic Items");
            Console.WriteLine("- Potions");
            Console.WriteLine("- Quest Items");
            Console.WriteLine("- Weapons");
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("What category would you like to access?");
            string userInput = Console.ReadLine();

            if (userInput.Length == 0)
            {
                Console.WriteLine();
                Console.WriteLine("That is not an option!");
                Console.WriteLine("Pplease try again!");
                Console.Clear();
            }
        }

    }
}
