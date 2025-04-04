using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Colossus : Entity
    {
        public static void SetAbilityScore()
        {
            Level = 14;
            XP = 11500;
            Health = 184;
            MaxHealth = 184;
            Armour = 22;
            Strength = 23;
            Dexterity = 8;
            Constitution = 25;
            Intelligence = 3;
            Wisdom = 11;
            Charisma = 1;
        }
    }
}
