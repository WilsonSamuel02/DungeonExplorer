using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class ShopNPC
    {

        public string ShopType { get; protected set; }
        public int Gold { get; protected set; }
        public List<Item> Stock { get; protected set; }

        public ShopNPC(int floor)
        {
            ShopType = "No Name";
            Gold = MerchantGold(floor);
            Stock = ShopStock(floor);
        }

        public virtual void Shop(Player player)
        {
            
        }

        protected virtual List<Item> ShopStock(int floor)
        {
            List<Item> stock = new List<Item>();

            return stock;
        }

        protected virtual int MerchantGold(int floor)
        {
            int gold = 0;

            return gold;
        }

        protected virtual void BuyMenu(Player player)
        {
            Console.Clear();
            Console.WriteLine("This is where the buy menu will go");
        }

        protected virtual void SellMenu(Player player)
        {
            Console.Clear();
            Console.WriteLine("This is where the sell menu will go");
        }

        protected virtual void TalkMenu(Player player)
        {
            Console.Clear();
            Console.WriteLine("This is where the talk menu will go");
        }

        protected int SellPrice(int total, int percentage)
        {
            int calculatedPercentage = (total * percentage) / 100;

            int sellPrice = total - calculatedPercentage;

            return sellPrice;
        }
    }
}
