using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Javelin : Weapons
    {
        public static void SetDescription()
        {
            Name = "Javelin";
            Description = "";
            ItemType = "Simple Melee";
            DamageType = "Piercing";
            WeaponProperties = new List<string> { "Thrown", "Slow" };
            Damage = new List<string> { "d6", "1" };
        }
    }
}
