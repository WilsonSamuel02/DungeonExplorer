using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Items : Item
    {
        public Items(string name, string itemType)
        {
            Name = name;
            ItemType = itemType;
        }
    }
}
