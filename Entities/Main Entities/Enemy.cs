using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal abstract class Enemy : Entity, IHealth
    {
        private List<string> _inventory;
        public string Description {  get; protected set; }

        public Enemy()
        {
            this._inventory = new List<string>();
        }

        public Enemy(string name)
        {
            Name = name;
            
            this._inventory = new List<string>();
        }

        public List<string> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }

        public void TakeDamage(int damageAmount)
        {
            Health -= damageAmount;
        }

        public void Heal(int healAmount)
        {
            Health += healAmount;
        }
    }
}
