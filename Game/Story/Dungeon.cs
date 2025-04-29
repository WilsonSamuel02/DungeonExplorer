using DungeonCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeoncrawler
{
    internal class Dungeon
    {
        public Dungeon() { }

        public static void DungeonGenerator()
        {
            BeginningRoom beginning = new BeginningRoom();
            beginning.GetDescription();
        }
    }
}
