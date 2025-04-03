using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Wizard : Entity
    {
        protected List<string> _resistance = new List<string>();
        public static void SetAbilityScore()
        {
            Health = 9;
            MaxHealth = 9;
            Armour = 11;
            Strength = 10;
            Dexterity = 12;
            Intelligence = 15;
            Constitution = 8;
            Wisdom = 14;
            Charisma = 13;
        }
    }
}
