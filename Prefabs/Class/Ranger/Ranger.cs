using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Ranger : Entity
    {
        protected List<string> _resistance = new List<string>();
        public static void SetAbilityScore()
        {
            Health = 11;
            MaxHealth = 11;
            Armour = 12;
            Strength = 13;
            Dexterity = 15;
            Intelligence = 8;
            Constitution = 12;
            Wisdom = 14;
            Charisma = 10;
        }
    }
}
