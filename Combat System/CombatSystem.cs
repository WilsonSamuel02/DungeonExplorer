using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer.Combat_System
{
    internal abstract class CombatSystem
    {
        protected int d4 = 4;
        protected int d6 = 6;
        protected int d8 = 8;
        protected int d10 = 10;
        protected int d12 = 12;
        protected int d20 = 20;

        public int Attack()
        {
            Random attackRoll = new Random();

            int attackDamage = attackRoll.Next(1, d20);

            return attackDamage;
        }

    }
}
