using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Tiefling : Entity
    {
        public static void SetDescription()
        {
            Specie = "Tiefling";
            Size = "medium";
            Speed = 30;
        }
    }
}
