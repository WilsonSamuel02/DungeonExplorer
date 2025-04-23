using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Merchant : ShopNPC
    {
        public Merchant(int floor) : base(floor)
        {
            ShopType = "Merchant";
            Gold = MerchantGold(floor);
            Stock = ShopStock(floor);
        }

        protected override void Shop()
        {
            /*
             * Main merchant shop code
             * 1. Merchant introduces themselves
             *      - needs gold and inventory based on floor
             * 2. Player is given options to pick from:
             *      - Buy
             *      - Sell
             *      - Talk
             * 3. Buy allows the player to buy any available stock from the merchant
             * 4. Sell allows the player to sell items as long as the merchant has enough money
             * 5. Talking gives the player a random response about the merchant from a pool of answers.
             */

            Console.Clear();
            Console.WriteLine("Welcome to Quality Merchants");
            Console.WriteLine("How can I help you?");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("-- What would you like to do --");
            Console.WriteLine();
            Console.WriteLine("- 'Buy'");
            Console.WriteLine("- 'Sell'");
            Console.WriteLine("- 'Talk'");
            Console.WriteLine();
            Console.WriteLine("------------------------------");

        }

        protected override int MerchantGold(int floor)
        {
            /*
             * Main gold randomiser
             * Depending on how many floors the player has reached the money will increase from the beginning amount
             * It will be randomised from certain thresholds i.e 300 - 400
             * It'll be returned to easily display info to player
             */

            Random randomGold = new Random();

            int gold = 0;

            if (floor <= 5) gold = randomGold.Next(50, 100);
            else if (floor <= 10) gold = randomGold.Next(100, 200);
            else if (floor <= 15 && floor > 10) gold = randomGold.Next(100, 200);
            else if (floor <= 25 && floor > 15) gold = randomGold.Next(300, 500);
            else if (floor <= 35 && floor > 25) gold = randomGold.Next(650, 800);
            else if (floor <= 55 && floor > 35) gold = randomGold.Next(850, 1000);
            else if (floor > 55 && floor < 75) gold = randomGold.Next(1500, 2000);
            else Debug.Assert(floor < 0 || floor > 75);

                return gold;
        }

        protected override List<Item> ShopStock(int floor)
        {
            /*
             * Main stock code
             * The shop will have a predetermined stock depending on what floor the player has reached
             * Stock:
             *      - Low level spells
             *      - Low level potions
             *      - Gear (lockpicks, pickaxe)
             *      - Low level weapons
             *      - Low level armor
             *      - Easily obtainable monster loot
             *      - Harder to obtain crafting items
             */

            List<Item> stock = new List<Item>();

            return stock;
        }

        protected override void BuyMenu()
        {
            /*
             * Main menu where the player will see what items the merchant has to offer
             * It will contain info like their name, How much gold they currently have and their stock
             * The merchants gold should increase accordingly depending on how much the item was
             */
        }

        protected override void SellShop()
        {
            /*
             * Main menu where the player can sell their items
             * It will still contain the merchants info and gold, however any sellable items tha tthe player can sell will be visible instead
             * The merchants gold should decrease accordingly depending on how much the item was
             */
        }

        protected override void TalkMenu()
        {
            /*
             * This option will simply print random phrases from a list that the merchant will say
             * They will have some relevance to the merchant for more immersion
             * As an added challenge the merchant could either say they forgot that they have mentioned something to the player, or include already said phrases as part of other phrases
             * After a few visits the merchant could perhaps learn the players name and have a different greeting.
             */
        }
    }
}
