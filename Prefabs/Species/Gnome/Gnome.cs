using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Gnome : Entity
    {
        public static void SetDescription()
        {
            Specie = "Gnome";
            Size = "small";
            Speed = 25;
        }
    }
}
