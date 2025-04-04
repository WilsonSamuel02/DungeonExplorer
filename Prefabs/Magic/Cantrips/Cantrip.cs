using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal abstract class Cantrip : Magic
    {
        public static string Type { get; protected set; }
        public static List<CombatClass> CombatClasses { get; protected set; }
    }
}
