using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class ShortBow : Weapons
    {
        public ShortBow() : base()
        {
            Name = "Short Bow";
            Description = "";
            ItemType = "Simple Ranged";
            SellAmount = 5;
            DamageType = "Piercing";
            WeaponProperties = new List<string> { "Ammunition", "Two-Handed" };
            Damage = 6;
        }
    }
}
