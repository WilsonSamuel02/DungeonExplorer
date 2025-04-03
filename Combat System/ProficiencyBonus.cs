using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer.Combat_System
{
    internal class ProficiencyBonus
    {
        public int GetProficiency(int level)
        {
            if (level >= 1 && level < 5) return 2;
            else if (level >= 5 && level < 9) return 3;
            else if (level >= 9 && level < 13) return 4;
            else if (level >= 13 && level < 17) return 5;
            else if (level >= 17) return 6;
            else return 0;
        }

    }
}
