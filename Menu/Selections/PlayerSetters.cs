using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class PlayerSetters : Entity
    {
        public static void ClassSelection(string combatClass)
        {
            switch (combatClass.ToLower())
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
                    Wizard.SetAbilityScore();
                    break;
            }
        }

        public static void SpeciesSelection(string speciesName)
        {
            switch (speciesName.ToLower())
            {
                case "dwarf":
                    Dwarf.SetDescription();
                    break;
                case "elf":
                    Elf.SetDescription();
                    break;
                case "halfling":
                    Halfling.SetDescription();
                    break;
                case "human":
                    Human.SetDescription();
                    break;
                case "dragonborn":
                    Dragonborn.SetDescription();
                    break;
                case "gnome":
                    Gnome.SetDescription();
                    break;
                case "goliath":
                    Goliath.SetDescription();
                    break;
                case "orc":
                    Orc.SetDescription();
                    break;
                case "tiefling":
                    Tiefling.SetDescription();
                    break;
                case "changeling":
                    Changeling.SetDescription();
                    break;
                case "shifter":
                    Shifter.SetDescription();
                    break;
                case "warforged":
                    Warforged.SetDescription();
                    break;
            }
        }
    }
}
