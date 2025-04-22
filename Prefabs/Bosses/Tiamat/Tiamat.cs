using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Tiamat : Entity
    {
        public void SetAbilityScore()
        {
            Level = 30;
            XP = 155000;
            Health = 615;
            MaxHealth = 615;
            Armour = 25;
            Strength = 30;
            Dexterity = 10;
            Constitution = 30;
            Intelligence = 26;
            Wisdom = 26;
            Charisma = 28;
        }
    }
}
