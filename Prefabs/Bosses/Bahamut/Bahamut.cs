using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Bahamut : Enemy
    {
        public Bahamut() : base()
        {
            Name = "Bahamut";
            Specie = "Dragon";
            Size = "Gargantuan";
            Level = 30;
            XP = 155000;
            Health = 585;
            MaxHealth = 585;
            Armour = 23;
            Strength = 30;
            Dexterity = 18;
            Constitution = 29;
            Intelligence = 25;
            Wisdom = 28;
            Charisma = 30;
        }
    }
}
