using System;

namespace DungeonCrawler
{
    internal class Enemy : CombatClass, IHealth
    {
        private List<string> _inventory;
        private List<> _traits;

        public Enemy(string enemySpecies, string combatClass, int enemyLevel)
        {
            Name = enemySpecies + combatClass
            ClassSelection(combatClass);

            this._inventory = new List<string>();
        }

        public void TakeDamage(int damageAmount)
        {
            base.Health -= damageAmount
        }

        public void Heal(int healAmount)
        {
            base.Health += healAmount;
        }

        public void MonsterDrop(string monsterSpecies)
        {
            
        }
    }
}
