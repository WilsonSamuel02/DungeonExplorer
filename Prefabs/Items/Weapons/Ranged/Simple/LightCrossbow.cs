using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class LightCrossbow : Weapons
    {
        public LightCrossbow() : base()
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
