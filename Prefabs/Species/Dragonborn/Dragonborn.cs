using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Dragonborn : Entity
    {
        public static void SetDescription()
        {
            Specie = "Dragonborn";
            Size = "medium";
            Speed = 30;
        }
    }
}
