using System;
using System.Collections.Generic;

namespace DungeonCrawler
{
    internal class Barbarian : Entity
    {
        protected List<string> _resistance = new List<string>();
        public static void SetAbilityScore()
        {
            Health = 12;
            MaxHealth = 12;
            Armour = 10;
            Strength = 15;
            Dexterity = 10;
            Intelligence = 12;
            Constitution = 14;
            Wisdom = 8;
            Charisma = 13;
        }

        public static int GetRageDamage(int level)
        {
            if (level >= 1 && level < 9) return 2;
            else if (level >= 9 && level < 16) return 3;
            else if (level >= 16 && level < 21) return 4;
            else return 0;
        }

        public static int GetRageAmount(int level)
        {
            if (level >= 1 && level < 3) return 2;
            else if (level >= 3 && level < 6) return 3;
            else if (level >= 6 && level < 12) return 4;
            else if (level >= 12 && level < 17) return 5;
            else if (level >= 17 && level < 21) return 6;
            else return 0;
        }

        public static int GetWeaponMastery(int level)
        {
            if (level >= 1 && level < 4) return 2;
            else if (level >= 4 && level < 12) return 3;
            else if (level >= 12 && level < 21) return 4;
            else return 0;
        }
    }
}