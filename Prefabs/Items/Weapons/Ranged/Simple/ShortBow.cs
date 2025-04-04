using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class ShortBow : Weapons
    {
        public static void SetDescription()
        {
            Name = "Short Bow";
            Description = "";
            ItemType = "Simple Ranged";
            DamageType = "Piercing";
            WeaponProperties = new List<string> { "Ammunition", "Two-Handed" };
            Damage = new List<string> { "d6", "1" };
        }
    }
}
