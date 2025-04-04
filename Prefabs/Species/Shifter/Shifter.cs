using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Shifter : Entity
    {
        public static void SetDescription()
        {
            Specie = "Shifter";
            Size = "medium";
            Speed = 30;
        }
    }
}
