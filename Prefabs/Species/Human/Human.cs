using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Human : Entity
    {
        public static void SetDescription()
        {
            Specie = "Human";
            Size = "medium";
            Speed = 30;
        }
    }
}
