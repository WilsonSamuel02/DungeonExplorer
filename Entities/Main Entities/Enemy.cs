using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    internal abstract class Enemy : Entity, IHealth, IPlayerAttack
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

        public void Attack(Player player)
        {
            Random random = new Random();
            int attackRoll = random.Next(1, 20);

            int bonusAttack = ProficiencyBonus.CalculateAttackProficiency(this);

            int attack = attackRoll + bonusAttack;

            if (attack > player.Armour)
            {
                int attackDamage = random.Next(1, Equipped.Damage);
                player.Health -= attackDamage;
            }
            else
            {
                Console.WriteLine("Attack Missed");
            }
        }
    }
}
