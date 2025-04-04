using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Club : Weapons
    {
        public static void SetDescription()
        {
            Name = "Club";
            Description = "";
            ItemType = "Simple Melee";
            DamageType = "Bludgeoning";
            WeaponProperties = new List<string> { "Light", "Slow" };
            Damage = new List<string> { "d4", "1" };
        }
    }
}
