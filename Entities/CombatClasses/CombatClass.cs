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
                    base.Armour = 12;
                    base.Strength = 14;
                    base.Dexterity = 13;
                    base.Intelligence = 15;
                    base.Constitution = 10;
                    base.Wisdom = 12;
                    base.Charisma = 8;
                    break;
                case "barbarian":
                    base.Health = 20;
                    base.MaxHealth = 20;
                    base.Armour = 20;
                    base.Strength = 15;
                    base.Dexterity = 10;
                    base.Intelligence = 12;
                    base.Constitution = 14;
                    base.Wisdom = 8;
                    base.Charisma = 13;
                    break;
                case "bard":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Armour = 8;
                    base.Strength = 8;
                    base.Dexterity = 14;
                    base.Intelligence = 13;
                    base.Constitution = 12;
                    base.Wisdom = 10;
                    base.Charisma = 15;
                    break;
                case "cleric":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Armour = 8;
                    base.Strength = 8;
                    base.Dexterity = 12;
                    base.Intelligence = 13;
                    base.Constitution = 10;
                    base.Wisdom = 15;
                    base.Charisma = 14;
                    break;
                case "druid":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Armour = 12;
                    base.Strength = 12;
                    base.Dexterity = 13;
                    base.Intelligence = 14;
                    base.Constitution = 10;
                    base.Wisdom = 15;
                    base.Charisma = 8;
                    break;
                case "fighter":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Armour = 16;
                    base.Strength = 13;
                    base.Dexterity = 15;
                    base.Intelligence = 12;
                    base.Constitution = 14;
                    base.Wisdom = 10;
                    base.Charisma = 8;
                    break;
                case "monk":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Armour = 12;
                    base.Strength = 13;
                    base.Dexterity = 15;
                    base.Intelligence = 12;
                    base.Constitution = 10;
                    base.Wisdom = 14;
                    base.Charisma = 8;
                    break;
                case "paladin":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Armour = 16;
                    base.Strength = 15;
                    base.Dexterity = 8;
                    base.Intelligence = 10;
                    base.Constitution = 12;
                    base.Wisdom = 13;
                    base.Charisma = 14;
                    break;
                case "ranger":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Armour = 12;
                    base.Strength = 13;
                    base.Dexterity = 15;
                    base.Intelligence = 8;
                    base.Constitution = 12;
                    base.Wisdom = 14;
                    base.Charisma = 10;
                    break;
                case "rogue":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Armour = 8;
                    base.Strength = 10;
                    base.Dexterity = 15;
                    base.Intelligence = 14;
                    base.Constitution = 12;
                    base.Wisdom = 8;
                    base.Charisma = 13;
                    break;
                case "sorcerer":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Armour = 2;
                    base.Strength = 10;
                    base.Dexterity = 8;
                    base.Intelligence = 12;
                    base.Constitution = 14;
                    base.Wisdom = 13;
                    base.Charisma = 15;
                    break;
                case "warlock":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Armour = 4;
                    base.Strength = 8;
                    base.Dexterity = 13;
                    base.Intelligence = 10;
                    base.Constitution = 12;
                    base.Wisdom = 14;
                    base.Charisma = 15;
                    break;
                case "wizard":
                    base.Health = 10;
                    base.MaxHealth = 10;
                    base.Armour = 2;
                    base.Strength = 10;
                    base.Dexterity = 12;
                    base.Intelligence = 15;
                    base.Constitution = 8;
                    base.Wisdom = 14;
                    base.Charisma = 13;
                    break;
            }
        }
    }
}
