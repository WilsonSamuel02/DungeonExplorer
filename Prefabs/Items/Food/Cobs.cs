using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Cobs : Food
    {
        public Cobs() : base()
        {
            Name = "Cob";
            Description = "No description";
            ItemType = "Food";
            SellAmount = 2;
            HealAmount = 5;
        }
    }
}
