using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Halfling : Entity
    {
        public static void SetDescription()
        {
            Specie = "Halfling";
            Size = "small";
            Speed = 30;
        }
    }
}
