using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Warlock : Entity
    {
        protected List<string> _resistance = new List<string>();
        public static void SetAbilityScore()
        {
            Health = 11;
            MaxHealth = 11;
            Armour = 11;
            Strength = 8;
            Dexterity = 13;
            Intelligence = 10;
            Constitution = 12;
            Wisdom = 14;
            Charisma = 15;
        }
    }
}
