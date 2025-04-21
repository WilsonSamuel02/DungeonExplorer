using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class FryingPan : Weapons
    {
        public FryingPan() : base()
        {
            Name = "Frying Pan";
            Description = "";
            ItemType = "Simple Melee";
            DamageType = "Bludgeoning";
            WeaponProperties = new List<string> { "Light", "Versatile" };
            Damage = new List<string> { "d4", "1" };
        }
    }
}
