using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal abstract class Item
    {
        public static string Name { get; protected set; }
        public static string Description { get; protected set; }
        public static string ItemType { get; protected set; }
    }
}
