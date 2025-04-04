using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class VampireLord : Entity
    {
        public static void SetAbilityScore()
        {
            Level = 20;
            XP = 25000;
            Health = 245;
            MaxHealth = 245;
            Armour = 19;
            Strength = 18;
            Dexterity = 20;
            Constitution = 21;
            Intelligence = 18;
            Wisdom = 18;
            Charisma = 20;
        }
    }
}
