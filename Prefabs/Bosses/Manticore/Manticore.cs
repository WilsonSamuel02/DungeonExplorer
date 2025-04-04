using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Manticore : Entity
    {
        public static void SetAbilityScore()
        {
            Level = 16;
            XP = 15000;
            Health = 183;
            MaxHealth = 183;
            Armour = 19;
            Strength = 17;
            Dexterity = 16;
            Constitution = 23;
            Intelligence = 7;
            Wisdom = 12;
            Charisma = 8;
        }
    }
}
