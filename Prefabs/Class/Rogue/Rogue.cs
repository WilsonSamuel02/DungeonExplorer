using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Rogue : Entity
    {
        protected List<string> _resistance = new List<string>();
        public static void SetAbilityScore()
        {
            Health = 11;
            MaxHealth = 11;
            Armour = 12;
            Strength = 10;
            Dexterity = 15;
            Intelligence = 14;
            Constitution = 12;
            Wisdom = 8;
            Charisma = 13;
        }
    }
}
