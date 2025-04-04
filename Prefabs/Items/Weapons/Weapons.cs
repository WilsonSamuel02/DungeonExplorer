using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal abstract class Weapons : Item
    {
        public static string DamageType { get; protected set; }
        public static List<string> WeaponProperties { get; protected set; }
        public static List<string> Damage {  get; protected set; }
    }
}
