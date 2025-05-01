using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Club : Weapons
    {
        public Club() : base()
        {
            Name = "Club";
            Description = "";
            ItemType = "Simple Melee";
            SellAmount = 5;
            DamageType = "Bludgeoning";
            WeaponProperties = new List<string> { "Light", "Slow" };
            Damage = 4;
        }
    }
}
