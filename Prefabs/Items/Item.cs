using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DungeonCrawler
{
    internal abstract class Item
    {
        //Properties
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string ItemType { get; protected set; }

        //Constructor
        public Item()
        {
            Name = "No Name";
            Description = "No description";
            ItemType = "No Item Type";
        }
    }
}
