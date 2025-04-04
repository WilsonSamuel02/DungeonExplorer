using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class OrcWarChief : Entity
    {
        public static void SetAbilityScore()
        {
            Level = 4;
            XP = 1100;
            Health = 93;
            MaxHealth = 93;
            Armour = 16;
            Strength = 18;
            Dexterity = 12;
            Constitution = 18;
            Intelligence = 11;
            Wisdom = 11;
            Charisma = 16;
        }
    }
}
