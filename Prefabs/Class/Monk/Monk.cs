using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Monk : Entity
    {
        protected List<string> _resistance = new List<string>();
        public static void SetAbilityScore()
        {
            Health = 10;
            MaxHealth = 10;
            Armour = 12;
            Strength = 13;
            Dexterity = 15;
            Intelligence = 12;
            Constitution = 10;
            Wisdom = 14;
            Charisma = 8;
        }
    }
}
