using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Javelin : Weapons
    {
        public Javelin() : base()
        {
            Name = "Javelin";
            Description = "";
            ItemType = "Simple Melee";
            SellAmount = 5;
            DamageType = "Piercing";
            WeaponProperties = new List<string> { "Thrown", "Slow" };
            Damage = 6;
        }
    }
}
