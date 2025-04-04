using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Basilisk : Entity
    {
        public static void SetAbilityScore()
        {
            Level = 6;
            XP = 2300;
            Health = 52;
            MaxHealth = 52;
            Armour = 15;
            Strength = 16;
            Dexterity = 8;
            Constitution = 16;
            Intelligence = 2;
            Wisdom = 8;
            Charisma = 7;
        }
    }
}
