using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Oni : Entity
    {
        public static void SetAbilityScore()
        {
            Level = 12;
            XP = 8400;
            Health = 157;
            MaxHealth = 157;
            Armour = 18;
            Strength = 19;
            Dexterity = 11;
            Constitution = 17;
            Intelligence = 14;
            Wisdom = 12;
            Charisma = 15;
        }
    }
}
