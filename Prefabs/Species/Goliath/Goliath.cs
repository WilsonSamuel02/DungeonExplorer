using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Goliath : Entity
    {
        public static void SetDescription()
        {
            Specie = "Goliath";
            Size = "medium";
            Speed = 30;
        }
    }
}
