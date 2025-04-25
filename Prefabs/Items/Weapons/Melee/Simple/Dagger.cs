using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Dagger : Weapons
    {
        public Dagger() : base()
        {
            Name = "Dagger";
            Description = "";
            ItemType = "Simple Melee";
            SellAmount = 5;
            DamageType = "Piercing";
            WeaponProperties = new List<string> { "Light", "Finesse", "Thrown", "Nick" };
            Damage = new List<string> { "d4", "1" };
        }
    }
}
