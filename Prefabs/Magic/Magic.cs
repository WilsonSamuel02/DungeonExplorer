using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal abstract class Magic
    {
        public static string Name { get; protected set; }
        public static string Description { get; protected set; }
        public static string School { get; protected set; }
        public static List<string> CastingTime { get; protected set; }
        public static string Range { get; protected set; }
        public static int Duration { get; protected set; }
        public static List<string> Components { get; protected set; }
    }
}
