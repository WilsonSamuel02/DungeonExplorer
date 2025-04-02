using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal abstract class CombatClass : Entity
    {
        protected void ClassSelection(string combatClass)
        {
            switch(combatClass.ToLower())
            {
                case "artificer":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Mana = 10;
                    base.MaxMana = 10;
                    base.Armour = 6;
                    base.Strength = 1;
                    base.Dexterity = 1;
                    base.Intelligence = 10;
                    base.Constitution = 1;
                    base.Wisdom = 1;
                    base.Charisma = 1;
                    break;
                case "barbarian":
                    base.Health = 20;
                    base.MaxHealth = 20;
                    base.Mana = 10;
                    base.MaxMana = 10;
                    base.Armour = 10;
                    base.Strength = 5;
                    base.Dexterity = 1;
                    base.Intelligence = 1;
                    base.Constitution = 5;
                    base.Wisdom = 1;
                    base.Charisma = 1;
                    break;
                case "bard":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Mana = 10;
                    base.MaxMana = 10;
                    base.Armour = 4;
                    base.Strength = 1;
                    base.Dexterity = 1;
                    base.Intelligence = 1;
                    base.Constitution = 1;
                    base.Wisdom = 1;
                    base.Charisma = 10;
                    break;
                case "cleric":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Mana = 10;
                    base.MaxMana = 10;
                    base.Armour = 4;
                    base.Strength = 1;
                    base.Dexterity = 1;
                    base.Intelligence = 1;
                    base.Constitution = 1;
                    base.Wisdom = 10;
                    base.Charisma = 1;
                    break;
                case "druid":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Mana = 10;
                    base.MaxMana = 10;
                    base.Armour = 6;
                    base.Strength = 1;
                    base.Dexterity = 1;
                    base.Intelligence = 1;
                    base.Constitution = 1;
                    base.Wisdom = 10;
                    base.Charisma = 1;
                    break;
                case "fighter":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Mana = 10;
                    base.MaxMana = 10;
                    base.Armour = 8;
                    base.Strength = 5;
                    base.Dexterity = 5;
                    base.Intelligence = 1;
                    base.Constitution = 1;
                    base.Wisdom = 1;
                    base.Charisma = 1;
                    break;
                case "monk":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Mana = 10;
                    base.MaxMana = 10;
                    base.Armour = 6;
                    base.Strength = 1;
                    base.Dexterity = 5;
                    base.Intelligence = 1;
                    base.Constitution = 1;
                    base.Wisdom = 5;
                    base.Charisma = 1;
                    break;
                case "paladin":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Mana = 10;
                    base.MaxMana = 10;
                    base.Armour = 8;
                    base.Strength = 5;
                    base.Dexterity = 1;
                    base.Intelligence = 1;
                    base.Constitution = 1;
                    base.Wisdom = 1;
                    base.Charisma = 5;
                    break;
                case "ranger":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Mana = 10;
                    base.MaxMana = 10;
                    base.Armour = 6;
                    base.Strength = 1;
                    base.Dexterity = 5;
                    base.Intelligence = 1;
                    base.Constitution = 1;
                    base.Wisdom = 5;
                    base.Charisma = 1;
                    break;
                case "rogue":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Mana = 10;
                    base.MaxMana = 10;
                    base.Armour = 4;
                    base.Strength = 1;
                    base.Dexterity = 10;
                    base.Intelligence = 1;
                    base.Constitution = 1;
                    base.Wisdom = 1;
                    base.Charisma = 1;
                    break;
                case "sorcerer":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Mana = 10;
                    base.MaxMana = 10;
                    base.Armour = 0;
                    base.Strength = 1;
                    base.Dexterity = 1;
                    base.Intelligence = 1;
                    base.Constitution = 1;
                    base.Wisdom = 1;
                    base.Charisma = 10;
                    break;
                case "warlock":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Mana = 10;
                    base.MaxMana = 10;
                    base.Armour = 2;
                    base.Strength = 1;
                    base.Dexterity = 1;
                    base.Intelligence = 1;
                    base.Constitution = 1;
                    base.Wisdom = 1;
                    base.Charisma = 10;
                    break;
                case "wizard":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Mana = 10;
                    base.MaxMana = 10;
                    base.Armour = 0;
                    base.Strength = 1;
                    base.Dexterity = 1;
                    base.Intelligence = 10;
                    base.Constitution = 1;
                    base.Wisdom = 1;
                    base.Charisma = 1;
                    break;
            }
        }
    }
}
