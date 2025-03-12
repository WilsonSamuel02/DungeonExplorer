using System;

namespace DungeonCrawler{

    public abstract class Entity{

        //main entity class that all entities (players and enemies) inherit from

        private string _name;
        private int _health;
        private int _maxHealth;
        private int _attack;
        private int _defense;

        public string Name{
            get { return _name; }
            set { _name = value; }
        }

        public int Health{
            get {return _health;}
            set { 
                if (_health <= 0){ _health = 0; }
                else if (Health > _maxHealth){ _health = _maxHealth; }
                else{ _health = value; }

            }
        }

        public int MaxHealth{
            get{ return _maxHealth; }
            set{ _maxHealth = value; }
        }

        public int Attack{
            get { return _attack; }
            set { _attack = value; }
        }

        public int Defense{
            get { return _defense; }
            set { _defense = value; }
        }
    }
}