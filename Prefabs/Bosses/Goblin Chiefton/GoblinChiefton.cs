using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class GoblinChiefton : Entity
    {
        public static void SetAbilityScore()
        {
            Level = 2;
            XP = 450;
            Health = 25;
            MaxHealth = 25;
            Armour = 17;
            Strength = 10;
            Dexterity = 15;
            Constitution = 11;
            Intelligence = 10;
            Wisdom = 8;
            Charisma = 10;
        }
    }
}
