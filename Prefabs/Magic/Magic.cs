using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal abstract class Magic
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string School { get; protected set; }
        public int CastingTurns { get; protected set; }
        public int Duration { get; protected set; }

        public Magic() { }
    }
}
