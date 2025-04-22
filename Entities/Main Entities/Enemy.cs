using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal abstract class Enemy : Entity, IHealth
    {
        private List<Item> _inventory;
        public string Description {  get; protected set; }

        public Enemy() : base()
        {
            this._inventory = new List<Item>();
        }

        public Enemy(string name) : base(name)
        {
            this._inventory = new List<Item>();
        }

        public List<Item> Inventory
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
