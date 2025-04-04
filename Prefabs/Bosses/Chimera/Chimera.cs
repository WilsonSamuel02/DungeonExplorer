using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Chimera : Entity
    {
        public static void SetAbilityScore()
        {
            Level = 8;
            XP = 3900;
            Health = 135;
            MaxHealth = 135;
            Armour = 15;
            Strength = 19;
            Dexterity = 11;
            Constitution = 20;
            Intelligence = 3;
            Wisdom = 14;
            Charisma = 10;
        }
    }
}
