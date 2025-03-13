using DungeonCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer.Entities
{
    internal abstract class CombatClass : Entity
    {
        public void CombatClassSelection(string combatClass)
        {
            
            if (combatClass.ToLower() == "barbarian")
            {
                Health = 25;
                MaxHealth = 25;
                Mana = 5;
                MaxMana = 5;
                Attack = 20;
                MagicAttack = 0;
                Defense = 10;
                MagicDefense = 0;
                Dexterity = 5;
            }
            else if (combatClass.ToLower() == "paladin")
            {
                Health = 15;
                MaxHealth = 15;
                Mana = 20;
                MaxMana = 20;
                Attack = 15;
                MagicAttack = 10;
                Defense = 25;
                MagicDefense = 10;
                Dexterity = 10;
            }
            else if (combatClass.ToLower() == "mage")
            {
                Health = 10;
                MaxHealth = 10;
                Mana = 30;
                MaxMana = 30;
                Attack = 5;
                MagicAttack = 20;
                Defense = 5;
                MagicDefense = 20;
                Dexterity = 10;
            }
            else if (combatClass.ToLower() == "ranger")
            {
                Health = 10;
                MaxHealth = 10;
                Mana = 5;
                MaxMana = 5;
                Attack = 10;
                MagicAttack = 0;
                Defense = 10;
                MagicDefense = 0;
                Dexterity = 25;
            }
            else
            {
                Console.WriteLine("Combat Class doesn't exist");
            }
        }
    }
}
