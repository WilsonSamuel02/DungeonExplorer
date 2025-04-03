using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Fighter : Entity
    {
        protected List<string> _resistance = new List<string>();
        public static void SetAbilityScore()
        {
            Health = 12;
            MaxHealth = 12;
            Armour = 12;
            Strength = 13;
            Dexterity = 15;
            Intelligence = 12;
            Constitution = 14;
            Wisdom = 10;
            Charisma = 8;
        }
    }
}
