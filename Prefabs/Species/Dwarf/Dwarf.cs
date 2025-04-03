using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Dwarf : Entity
    {
        public static void SetDescription()
        {
            Specie = "Dwarf";
            Size = "Medium";
            Speed = 30;
        }
    }
}
