using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Spell : Magic
    {
        public static string Type { get; protected set; }

        public Spell() : base() { }
    }
}
