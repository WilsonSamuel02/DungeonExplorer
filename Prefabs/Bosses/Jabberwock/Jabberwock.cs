using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Jabberwock : Entity
    {
        public static void SetAbilityScore()
        {
            Level = 26;
            XP = 90000;
            Health = 291;
            MaxHealth = 291;
            Armour = 19;
            Strength = 20;
            Dexterity = 12;
            Constitution = 27;
            Intelligence = 4;
            Wisdom = 7;
            Charisma = 11;
        }
    }
}
