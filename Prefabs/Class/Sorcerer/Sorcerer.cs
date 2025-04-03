using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Sorcerer : Entity
    {
        protected List<string> _resistance = new List<string>();
        public static void SetAbilityScore()
        {
            Health = 12;
            MaxHealth = 12;
            Armour = 9;
            Strength = 10;
            Dexterity = 8;
            Intelligence = 12;
            Constitution = 14;
            Wisdom = 13;
            Charisma = 15;
        }
    }
}
