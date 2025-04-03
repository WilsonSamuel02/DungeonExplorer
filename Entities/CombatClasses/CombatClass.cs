using DungeonExplorer.Prefabs.Class.Cleric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class CombatClass : Entity
    {
        public static void ClassSelection(string combatClass)
        {
            switch(combatClass.ToLower())
            {
                case "artificer":
                    Artificer.SetAbilityScore();
                    break;
                case "barbarian":
                    Barbarian.SetAbilityScore();
                    break;
                case "bard":
                    Bard.SetAbilityScore();
                    break;
                case "cleric":
                    Cleric.SetAbilityScore();
                    break;
                case "druid":
                    Druid.SetAbilityScore();
                    break;
                case "fighter":
                    Fighter.SetAbilityScore();
                    break;
                case "monk":
                    Monk.SetAbilityScore();
                    break;
                case "paladin":
                    Paladin.SetAbilityScore();
                    break;
                case "ranger":
                    Ranger.SetAbilityScore();
                    break;
                case "rogue":
                    Rogue.SetAbilityScore();
                    break;
                case "sorcerer":
                    Sorcerer.SetAbilityScore();
                    break;
                case "warlock":
                    Warlock.SetAbilityScore();
                    break;
                case "wizard":
                    Health = 9;
                    MaxHealth = 9;
                    Armour = 11;
                    Strength = 10;
                    Dexterity = 12;
                    Intelligence = 15;
                    Constitution = 8;
                    Wisdom = 14;
                    Charisma = 13;
                    break;
            }
        }
    }
}
