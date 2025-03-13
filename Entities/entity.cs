using System;
using System.Web;

namespace DungeonCrawler{

    internal abstract class Entity{

        //main entity class that all entities (players and enemies) inherit from

        private int _health;

        public string Name { get; set; }
        public string CombatClassId { get; set; }
        public int MaxHealth { get; protected set; }
        public int Mana { get; protected set; }
        public int MaxMana { get; protected set; }
        public int Attack {  get; protected set; }
        public int MagicAttack { get; protected set; }
        public int Defense { get; protected set; }
        public int MagicDefense { get; protected set; }
        public int Dexterity { get; protected set; }

        

        public int Health{
            get {return _health;}
            protected set { 
                if (_health <= 0){ _health = 0; }
                else if (Health > MaxHealth){ _health = MaxHealth; }
                else{ _health = value; }

            }
        }
    }
}