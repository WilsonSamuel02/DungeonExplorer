using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Hydra : Entity
    {
        public static void SetAbilityScore()
        {
            Level = 10;
            XP = 5900;
            Health = 199;
            MaxHealth = 199;
            Armour = 16;
            Strength = 20;
            Dexterity = 12;
            Constitution = 21;
            Intelligence = 2;
            Wisdom = 10;
            Charisma = 7;
        }
    }
}
