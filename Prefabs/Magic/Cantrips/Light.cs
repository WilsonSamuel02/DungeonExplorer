using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Light : Cantrip
    {
        public static void SetDescription()
        {
            Name = "Light";
            Type = "Cantrip";
            CombatClasses = new List<string>() { "Artificer", "Bard", "Cleric", "Sorcerer", "Wizard" };
            Description = "";
            School = "Evocation";
            CastingTime = new List<string> { "Action", "1" };
            Range = "Touch";
            Duration = 60;
            Components = new List<string> { "Verbal", "Material" };
        }
    }
}
