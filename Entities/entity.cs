using System;
using System.Collections.Generic;

namespace DungeonCrawler{

    internal abstract class Entity{

        //main entity class that all entities (players and enemies) inherit from

        public string Name { get; protected set; }
        public string Gender { get; protected set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public int Gold { get; set; }
        public Weapons Equipped { get; set; }
        public string Specie { get; protected set; }
        public string Class { get; protected set; }
        public string Size { get; protected set;}
        public int Speed { get; protected set; }
        public int Health { get; protected set; }
        public int MaxHealth { get; protected set; }
        public int Armour { get; protected set; }
        public List<string> Resistance { get; protected set; }
        public int Strength {  get; protected set; }
        public int Dexterity { get; protected set; }
        public int Intelligence { get; protected set; }
        public int Constitution { get; protected set; }
        public int Wisdom { get; protected set; }
        public int Charisma { get; protected set; }

        public Entity() { }

        public Entity(string name, string gender, string combatClass, string species, int level = 1, int xp = 0, int gold = 0)
        {
            Name = name;
            Gender = gender;
            Level = level;
            XP = xp;
            Gold = gold;
            Class = combatClass;
            Specie = species;
        }

        public Entity(string name)
        {
            Name = name;
        }
    }
}