using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class EldrichLich : Entity
    {
        public EldrichLich() : base()
        {
            Name = "Eldrich Lich";
            Specie = "Abberation";
            Size = "Medium";
            Level = 18;
            XP = 20000;
            Health = 190;
            MaxHealth = 190;
            Armour = 18;
            Strength = 11;
            Dexterity = 18;
            Constitution = 17;
            Intelligence = 19;
            Wisdom = 14;
            Charisma = 12;
        }
    }
}
