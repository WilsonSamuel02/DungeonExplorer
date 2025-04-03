using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Paladin : Entity
    {
        protected List<string> _resistance = new List<string>();
        public static void SetAbilityScore()
        {
            Health = 11;
            MaxHealth = 11;
            Armour = 12;
            Strength = 15;
            Dexterity = 14;
            Intelligence = 8;
            Constitution = 12;
            Wisdom = 10;
            Charisma = 13;
        }
    }
}
