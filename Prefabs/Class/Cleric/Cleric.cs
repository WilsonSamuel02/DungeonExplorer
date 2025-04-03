using DungeonCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Cleric : Entity
    {
        protected List<string> _resistance = new List<string>();
        public static void SetAbilityScore()
        {
            Health = 10;
            MaxHealth = 10;
            Armour = 11;
            Strength = 8;
            Dexterity = 12;
            Intelligence = 13;
            Constitution = 10;
            Wisdom = 15;
            Charisma = 14;
        }
    }
}
