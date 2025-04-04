using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Cantrip : Magic
    {
        public static string Type { get; protected set; }
        public static List<string> CombatClasses { get; protected set; }
    }
}
