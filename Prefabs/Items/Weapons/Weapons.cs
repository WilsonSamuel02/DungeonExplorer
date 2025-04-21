using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal class Weapons : Item
    {

        public string DamageType { get; protected set; }
        public List<string> WeaponProperties { get; protected set; }
        public List<string> Damage {  get; protected set; }

        public Weapons() : base()
        {
            DamageType = "No Damage Type";
            WeaponProperties = new List<string> { "N/A" };
            Damage = new List<string> { "N/A" };
        }
    }
}
