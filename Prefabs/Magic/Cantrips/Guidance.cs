using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Guidance : Cantrip
    {
        public static void SetDescription()
        {
            Name = "Guidance";
            Type = "Cantrip";
            CombatClasses = new List<string> { "Artificer", "Cleric", "Druid" };
            Description = "";
            School = "Divination";
            CastingTime = new List<string> { "Action", "1" };
            Range = "Touch";
            Duration = 1;
            Components = new List<string> { "Verbal", "Somatic" };
        }
    }
}
