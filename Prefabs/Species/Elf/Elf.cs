using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Elf : Entity
    {
        public static void SetDescription()
        {
            Specie = "Elf";
            Size = "medium";
            Speed = 30;
        }
    }
}
