using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class ArclightPhoenix : Enemy
    {
        public ArclightPhoenix() : base()
        {
            Name = "Arclight Phoenix";
            Specie = "Monstrosity";
            Size = "Medium";
            Level = 28;
            XP = 120000;
            Health = 432;
            MaxHealth = 432;
            Armour = 18;
            Strength = 15;
            Dexterity = 22;
            Constitution = 26;
            Intelligence = 5;
            Wisdom = 12;
            Charisma = 7;
        }
    }
}
