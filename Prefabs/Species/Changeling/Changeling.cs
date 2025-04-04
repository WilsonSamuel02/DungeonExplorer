using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Changeling : Entity
    {
        public static void SetDescription()
        {
            Specie = "Changeling";
            Size = "small";
            Speed = 30;
        }
    }
}
