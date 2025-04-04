using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DungeonCrawler
{
    internal class Mending : Cantrip
    {
        public static void SetDescription()
        {
            Name = "Mending";
            Type = "Cantrip";
            CombatClasses = new List<string>() { "Artificer", "Bard", "Cleric", "Druid", "Sorcerer", "Wizard" };
            Description = "This spell repairs a single break or tear in an object you touch, " +
                "such as a broken chainlink, two halves of a broken key, a torn cloak, or a leaking wineskin. " +
                "As long as the break or tear is no larger than 1 foot in any dimension, you mend it, " +
                "leaving no trace of the former damage.";
            School = "Transmutation";
            CastingTime = new List<string> { "Minute", "1" };
            Range = "Touch";
            Duration = 0;
            Components = new List<string> { "Verbal", "Somatic", "Material" };
        }
    }
}
