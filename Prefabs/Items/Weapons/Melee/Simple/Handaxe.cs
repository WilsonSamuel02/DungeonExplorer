using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Handaxe : Weapons
    {
        public static void SetDescription()
        {
            Name = "Hand Axe";
            Description = "";
            ItemType = "Simple Melee";
            DamageType = "Slashing";
            WeaponProperties = new List<string> { "Light", "Thrown" };
            Damage = new List<string> { "d6", "1" };
        }
    }
}
