using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class LightCrossbow : Weapons
    {
        public static void SetDescription()
        {
            Name = "Light Crossbow";
            Description = "";
            ItemType = "Simple Ranged";
            DamageType = "Piercing";
            WeaponProperties = new List<string> { "Ammunition", "Loading", "Two-Handed" };
            Damage = new List<string> { "d8", "1" };
        }
    }
}
