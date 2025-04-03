using System;

namespace DungeonCrawler
{
    internal static class Barbarian : Entity
    {
        protected resistance = new List<string>();
        public void SetAbilityScore()
        {
            base.Health = 12;
            base.MaxHealth = 12;
            base.Armour = 10;
            base.Strength = 15;
            base.Dexterity = 10;
            base.Intelligence = 12;
            base.Constitution = 14;
            base.Wisdom = 8;
            base.Charisma = 13;
        }

        public int GetRageDamage(int level)
        {
            if (level >= 1 && level < 9) return 2;
            else if (level >= 9 && level < 16) return 3;
            else if (level >= 16 && level < 21) return 4;
            else return 0;
        }

        public int GetRageAmount(int level)
        {
            if (level >= 1 && level < 3) return 2;
            else if (level >= 3 && level < 6) return 3;
            else if (level >= 6 && level < 12) return 4;
            else if (level >= 12 && level < 17) return 5;
            else if (level >= 17 && level < 21) return 6;
            else return 0;
        }

        public int GetWeaponMastery(int level)
        {
            if (level >= 1 && level < 4) return 2;
            else if (level >= 4 && level < 12) return 3;
            else if (level >= 12 && level < 21) return 4;
            else return 0;
        }
    }
}