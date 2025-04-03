using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Druid : Entity
    {
        protected List<string> _resistance = new List<string>();
        public static void SetAbilityScore()
        {
            Health = 10;
            MaxHealth = 10;
            Armour = 11;
            Strength = 12;
            Dexterity = 13;
            Intelligence = 14;
            Constitution = 10;
            Wisdom = 15;
            Charisma = 8;
        }
    }
}
