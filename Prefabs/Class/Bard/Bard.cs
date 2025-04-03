using DungeonCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Bard : Entity
    {
        protected List<string> _resistance = new List<string>();

        public static void SetAbilityScore()
        {
            Health = 11;
            MaxHealth = 11;
            Armour = 12;
            Strength = 8;
            Dexterity = 14;
            Intelligence = 13;
            Constitution = 12;
            Wisdom = 10;
            Charisma = 15;
        }
    }
}
