using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Warforged : Entity
    {
        public static void SetDescription()
        {
            Specie = "Warforged";
            Size = "medium";
            Speed = 30;
        }
    }
}
