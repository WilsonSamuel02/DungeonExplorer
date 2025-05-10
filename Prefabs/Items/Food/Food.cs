using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal abstract class Food : Item
    {
        public int HealAmount {  get; protected set; }
        public Food()
        {
            HealAmount = 0;
        }
    }
}
