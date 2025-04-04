using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Artificer : Entity 
    {
        protected List<string> _resistance = new List<string>();

        public static void SetAbilityScore()
        {
            Health = 10;
            MaxHealth = 10;
            Armour = 11;
            Strength = 14;
            Dexterity = 13;
            Intelligence = 15;
            Constitution = 10;
            Wisdom = 12;
            Charisma = 8;
        }
    }
}
