using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Orc : Entity
    {
        public static void SetDescription()
        {
            Specie = "Orc";
            Size = "medium";
            Speed = 30;
        }
    }
}
