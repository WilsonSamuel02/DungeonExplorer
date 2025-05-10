using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Baphomet : Enemy
    {
        public Baphomet() : base()
        {
            Name = "Baphomet";
            Specie = "Demon";
            Size = "Huge";
            Level = 22;
            XP = 41000;
            Health = 292;
            MaxHealth = 292;
            Armour = 22;
            Strength = 30;
            Dexterity = 14;
            Constitution = 26;
            Intelligence = 18;
            Wisdom = 24;
            Charisma = 16;
        }
    }
}
