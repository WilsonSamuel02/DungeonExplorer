using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal interface IEnemyAttack
    {
        void Attack(Player player);
    }
}
