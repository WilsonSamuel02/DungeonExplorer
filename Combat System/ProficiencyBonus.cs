using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class ProficiencyBonus
    {
        public static int GetProficiency(int level)
        {
            if (level >= 1 && level < 5) return 2;
            else if (level >= 5 && level < 9) return 3;
            else if (level >= 9 && level < 13) return 4;
            else if (level >= 13 && level < 17) return 5;
            else if (level >= 17) return 6;
            else return 0;
        }

        public static int CalculateAttackProficiency(Player player)
        {
            switch(player.Class.ToLower())
            {

                case "artificer":
                    int abilityScore = CalculateAbilityScore(player.Intelligence);
                    int proficiencyBonus = GetProficiency(player.Level);
                    return abilityScore + proficiencyBonus;
                case "barbarian":
                    abilityScore = CalculateAbilityScore(player.Strength);
                    proficiencyBonus = GetProficiency(player.Level);
                    return abilityScore + proficiencyBonus;
                case "bard":
                    abilityScore = CalculateAbilityScore(player.Charisma);
                    proficiencyBonus = GetProficiency(player.Level);
                    return abilityScore + proficiencyBonus;
                case "cleric":
                    abilityScore = CalculateAbilityScore(player.Wisdom);
                    proficiencyBonus = GetProficiency(player.Level);
                    return abilityScore + proficiencyBonus;
                case "druid":
                    abilityScore = CalculateAbilityScore(player.Wisdom);
                    proficiencyBonus = GetProficiency(player.Level);
                    return abilityScore + proficiencyBonus;
                case "fighter":
                    abilityScore = CalculateAbilityScore(player.Strength);
                    proficiencyBonus = GetProficiency(player.Level);
                    return abilityScore + proficiencyBonus;
                case "monk":
                    abilityScore = CalculateAbilityScore(player.Wisdom);
                    proficiencyBonus = GetProficiency(player.Level);
                    return abilityScore + proficiencyBonus;
                case "paladin":
                    abilityScore = CalculateAbilityScore(player.Charisma);
                    proficiencyBonus = GetProficiency(player.Level);
                    return abilityScore + proficiencyBonus;
                case "ranger":
                    abilityScore = CalculateAbilityScore(player.Dexterity);
                    proficiencyBonus = GetProficiency(player.Level);
                    return abilityScore + proficiencyBonus;
                case "rogue":
                    abilityScore = CalculateAbilityScore(player.Dexterity);
                    proficiencyBonus = GetProficiency(player.Level);
                    return abilityScore + proficiencyBonus;
                case "sorcerer":
                    break;
                case "warlock":
                    abilityScore = CalculateAbilityScore(player.Charisma);
                    proficiencyBonus = GetProficiency(player.Level);
                    return abilityScore + proficiencyBonus;
                case "wizard":
                    abilityScore = CalculateAbilityScore(player.Intelligence);
                    proficiencyBonus = GetProficiency(player.Level);
                    return abilityScore + proficiencyBonus;
            }
            return 0;
        }

        public static int CalculateAttackProficiency(Enemy enemy)
        {
            switch (enemy.Class.ToLower())
            {

                case "artificer":
                    int abilityScore = CalculateAbilityScore(enemy.Intelligence);
                    int proficiencyBonus = GetProficiency(enemy.Level);
                    return abilityScore + proficiencyBonus;
                case "barbarian":
                    abilityScore = CalculateAbilityScore(enemy.Strength);
                    proficiencyBonus = GetProficiency(enemy.Level);
                    return abilityScore + proficiencyBonus;
                case "bard":
                    abilityScore = CalculateAbilityScore(enemy.Charisma);
                    proficiencyBonus = GetProficiency(enemy.Level);
                    return abilityScore + proficiencyBonus;
                case "cleric":
                    abilityScore = CalculateAbilityScore(enemy.Wisdom);
                    proficiencyBonus = GetProficiency(enemy.Level);
                    return abilityScore + proficiencyBonus;
                case "druid":
                    abilityScore = CalculateAbilityScore(enemy.Wisdom);
                    proficiencyBonus = GetProficiency(enemy.Level);
                    return abilityScore + proficiencyBonus;
                case "fighter":
                    abilityScore = CalculateAbilityScore(enemy.Strength);
                    proficiencyBonus = GetProficiency(enemy.Level);
                    return abilityScore + proficiencyBonus;
                case "monk":
                    abilityScore = CalculateAbilityScore(enemy.Wisdom);
                    proficiencyBonus = GetProficiency(enemy.Level);
                    return abilityScore + proficiencyBonus;
                case "paladin":
                    abilityScore = CalculateAbilityScore(enemy.Charisma);
                    proficiencyBonus = GetProficiency(enemy.Level);
                    return abilityScore + proficiencyBonus;
                case "ranger":
                    abilityScore = CalculateAbilityScore(enemy.Dexterity);
                    proficiencyBonus = GetProficiency(enemy.Level);
                    return abilityScore + proficiencyBonus;
                case "rogue":
                    abilityScore = CalculateAbilityScore(enemy.Dexterity);
                    proficiencyBonus = GetProficiency(enemy.Level);
                    return abilityScore + proficiencyBonus;
                case "sorcerer":
                    break;
                case "warlock":
                    abilityScore = CalculateAbilityScore(enemy.Charisma);
                    proficiencyBonus = GetProficiency(enemy.Level);
                    return abilityScore + proficiencyBonus;
                case "wizard":
                    abilityScore = CalculateAbilityScore(enemy.Intelligence);
                    proficiencyBonus = GetProficiency(enemy.Level);
                    return abilityScore + proficiencyBonus;
            }
            return 0;
        }

        public static int CalculateAbilityScore(int abilityScore)
        {
            if (abilityScore == 1) return -5;
            else if (abilityScore == 2 || abilityScore == 3) return -4;
            else if (abilityScore == 4 || abilityScore == 5) return -3;
            else if (abilityScore == 6 || abilityScore == 7) return -2;
            else if (abilityScore == 8 || abilityScore == 9) return -1;
            else if (abilityScore == 10 || abilityScore == 11) return 0;
            else if (abilityScore == 12 || abilityScore == 13) return 1;
            else if (abilityScore == 14 || abilityScore == 15) return 2;
            else if (abilityScore == 16 || abilityScore == 17) return 3;
            else if (abilityScore == 18 || abilityScore == 19) return 4;
            else if (abilityScore == 20 || abilityScore == 21) return 5;
            else if (abilityScore == 22 || abilityScore == 23) return 6;
            else if (abilityScore == 24 || abilityScore == 25) return 7;
            else if (abilityScore == 26 || abilityScore == 27) return 8;
            else if (abilityScore == 28 || abilityScore == 29) return 9;
            else return 10;
        }

    }
}
